using Agriflora.Helpers;
using Agriflora.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Agriflora.Controllers
{
    public class PesananController
    {
        public int Checkout(List<RincianPesanan> items, decimal totalHarga, string metodeBayar)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — masukkan data ke tabel pesanan dan dapatkan id_pesanan yang baru dibuat
                int idPesanan;
                using (var cmd = new NpgsqlCommand(
                    @"INSERT INTO pesanan (id_pengguna, tanggal_pesanan, total_harga, status_pesanan)
                      VALUES (@id_pengguna, @tanggal, @total, @status)
                      RETURNING id_pesanan", conn))
                {
                    cmd.Parameters.AddWithValue("id_pengguna", AppSession.CurrentUser.IdPengguna);
                    cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
                    cmd.Parameters.AddWithValue("total", (double)totalHarga);
                    cmd.Parameters.AddWithValue("status", Status.MenungguPembayaran.ToString());

                    idPesanan = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Step 2 — masukkan setiap item ke tabel rincian_pesanan
                foreach (var item in items)
                {
                    using var cmd = new NpgsqlCommand(
                        @"INSERT INTO rincian_pesanan (id_pesanan, id_produk, jumlah, harga, subtotal)
                          VALUES (@id_pesanan, @id_produk, @jumlah, @harga, @subtotal)", conn);

                    cmd.Parameters.AddWithValue("id_pesanan", idPesanan);
                    cmd.Parameters.AddWithValue("id_produk", item.IdProduk);
                    cmd.Parameters.AddWithValue("jumlah", item.Quantity);
                    cmd.Parameters.AddWithValue("harga", item.Harga);
                    cmd.Parameters.AddWithValue("subtotal", item.Subtotal);

                    cmd.ExecuteNonQuery();
                }

                // Step 3 — masukkan data pembayaran dengan status "Belum Bayar"
                using (var cmd = new NpgsqlCommand(
                    @"INSERT INTO pembayaran (id_pesanan, metode_bayar, status_bayar, tanggal_bayar, deadline_bayar)
                      VALUES (@id_pesanan, @metode, @status, @tanggal, @deadline)", conn))
                {
                    cmd.Parameters.AddWithValue("id_pesanan", idPesanan);
                    cmd.Parameters.AddWithValue("metode", metodeBayar);
                    cmd.Parameters.AddWithValue("status", "Belum Bayar");
                    cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
                    cmd.Parameters.AddWithValue("deadline", DateTime.Now.AddHours(24));

                    cmd.ExecuteNonQuery();
                }

                return idPesanan;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Checkout error: " + ex);
                MessageBox.Show("Gagal checkout. Error: " + ex.Message);
                return -1;
            }
        }

        public bool KonfirmasiPembayaran(int idPesanan)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var trx = conn.BeginTransaction();

            try
            {

                // Cek status pesanan saat ini — kalau sudah pernah dikonfirmasi
                // (misal sudah Diproses/selesai), jangan kurangi stok lagi
                // supaya konfirmasi ganda tidak mengurangi stok dua kali.
                string statusSekarang;
                using (var cmdCek = new NpgsqlCommand(
                    @"SELECT status_pesanan FROM pesanan WHERE id_pesanan = @id_pesanan", conn, trx))
                {
                    cmdCek.Parameters.AddWithValue("id_pesanan", idPesanan);
                    var hasil = cmdCek.ExecuteScalar();
                    if (hasil == null || hasil == DBNull.Value)
                    {
                        MessageBox.Show("Pesanan tidak ditemukan.");
                        trx.Rollback();
                        return false;
                    }
                    statusSekarang = hasil.ToString();
                }

                bool belumDiproses = string.Equals(
                    statusSekarang, Status.MenungguPembayaran.ToString(), StringComparison.OrdinalIgnoreCase);

                if (belumDiproses)
                {
                    // Step 1 — pastikan stok semua item cukup sebelum dikurangi
                    using var cmdCekStok = new NpgsqlCommand(
                        @"SELECT r.id_produk, r.jumlah, p.nama_produk, p.stok
                          FROM rincian_pesanan r
                          JOIN produk p ON p.id_produk = r.id_produk
                          WHERE r.id_pesanan = @id_pesanan AND p.stok < r.jumlah", conn, trx);
                    cmdCekStok.Parameters.AddWithValue("id_pesanan", idPesanan);

                    using (var readerCek = cmdCekStok.ExecuteReader())
                    {
                        if (readerCek.Read())
                        {
                            string namaProduk = readerCek["nama_produk"].ToString();
                            int stokTersedia = Convert.ToInt32(readerCek["stok"]);
                            readerCek.Close();

                            MessageBox.Show(
                                $"Stok produk '{namaProduk}' tidak cukup (sisa {stokTersedia}). " +
                                "Konfirmasi pembayaran dibatalkan.",
                                "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            trx.Rollback();
                            return false;
                        }
                    }

                    // Step 2 — kurangi stok produk sesuai jumlah yang dipesan
                    using var cmdStok = new NpgsqlCommand(
                        @"UPDATE produk p
                          SET stok = p.stok - r.jumlah
                          FROM rincian_pesanan r
                          WHERE p.id_produk = r.id_produk
                            AND r.id_pesanan = @id_pesanan
                            AND p.stok >= r.jumlah", conn, trx);
                    cmdStok.Parameters.AddWithValue("id_pesanan", idPesanan);
                    cmdStok.ExecuteNonQuery();
                }

                // update pembayaran status
                using var cmdBayar = new NpgsqlCommand(
                    @"UPDATE pembayaran SET status_bayar = 'Lunas', tanggal_bayar = @tanggal
                      WHERE id_pesanan = @id_pesanan", conn, trx);

                cmdBayar.Parameters.AddWithValue("tanggal", DateTime.Now);
                cmdBayar.Parameters.AddWithValue("id_pesanan", idPesanan);
                cmdBayar.ExecuteNonQuery();

                // update pesanan status
                using var cmdPesanan = new NpgsqlCommand(
                    @"UPDATE pesanan SET status_pesanan = @status
                      WHERE id_pesanan = @id_pesanan", conn, trx);

                cmdPesanan.Parameters.AddWithValue("status", Status.Diproses.ToString());
                cmdPesanan.Parameters.AddWithValue("id_pesanan", idPesanan);
                cmdPesanan.ExecuteNonQuery();

                trx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trx.Rollback();
                Debug.WriteLine("KonfirmasiPembayaran error: " + ex);
                MessageBox.Show("Gagal konfirmasi. Error: " + ex.Message);
                return false;
            }
        }

        public List<PesananHeader> GetPesananByPengguna(int idPengguna)
        {
            var list = new List<PesananHeader>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                var sample = new PesananHeader();
                using var cmd = new NpgsqlCommand(sample.GetSelectQuery(), conn);
                cmd.Parameters.AddWithValue("id", idPengguna);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var header = new PesananHeader();
                    // Gunakan Id (dari BaseModel), bukan IdPesanan langsung
                    header.Id = Convert.ToInt32(reader["id_pesanan"]);
                    header.IdPengguna = Convert.ToInt32(reader["id_pengguna"]);
                    header.TanggalPesanan = ((DateOnly)reader["tanggal_pesanan"]).ToDateTime(TimeOnly.MinValue);
                    header.TotalHarga = Convert.ToDouble(reader["total_harga"]);
                    header.Status = Enum.Parse<Status>(reader["status_pesanan"].ToString(), true);
                    list.Add(header);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetPesananByPengguna error: " + ex.Message);
                Debug.WriteLine("GetPesananByPengguna error: " + ex);
            }
            return list;
        }

        public List<RincianPesanan> GetRincianByPesanan(int idPesanan)
        {
            var list = new List<RincianPesanan>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                using var cmd = new NpgsqlCommand(
                    @"SELECT r.*, p.nama_produk, p.gambar
                  FROM rincian_pesanan r
                  JOIN produk p ON r.id_produk = p.id_produk
                  WHERE r.id_pesanan = @id", conn);
                cmd.Parameters.AddWithValue("id", idPesanan);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RincianPesanan
                    {
                        IdRincian = Convert.ToInt32(reader["id_rincian"]),
                        IdPesanan = Convert.ToInt32(reader["id_pesanan"]),
                        IdProduk = Convert.ToInt32(reader["id_produk"]),
                        Quantity = Convert.ToInt32(reader["jumlah"]),
                        Harga = Convert.ToDecimal(reader["harga"]),
                        Subtotal = Convert.ToDecimal(reader["subtotal"]),
                        NamaProduk = reader["nama_produk"].ToString(),
                        Gambar = reader["gambar"] as byte[]
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("GetRincianByPesanan error: " + ex);
            }
            return list;
        }

        public bool UpdateStatus(PesananHeader pesanan, Status statusBaru)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Gunakan GetUpdateStatusQuery() dan pesanan.Id dari BaseModel
                using var cmd = new NpgsqlCommand(pesanan.GetUpdateStatusQuery(), conn);
                cmd.Parameters.AddWithValue("status", statusBaru.ToString());
                cmd.Parameters.AddWithValue("id", pesanan.Id); // <-- pakai Id, bukan IdPesanan
                cmd.ExecuteNonQuery();

                pesanan.Status = statusBaru; // update objek in-memory juga
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateStatus error: " + ex.Message);
                Debug.WriteLine(ex);
                return false;
            }
        }

        public List<PesananHeader> GetPesananByStatus(int idPengguna, Status status)
        {
            var list = new List<PesananHeader>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                var sample = new PesananHeader();
                using var cmd = new NpgsqlCommand(
                    $"SELECT * FROM {sample.GetTableName()} WHERE id_pengguna = @id AND status_pesanan = @status ORDER BY tanggal_pesanan DESC", conn);
                cmd.Parameters.AddWithValue("id", idPengguna);
                cmd.Parameters.AddWithValue("status", status.ToString());
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var header = new PesananHeader();
                    header.Id = Convert.ToInt32(reader["id_pesanan"]);
                    header.IdPengguna = Convert.ToInt32(reader["id_pengguna"]);
                    header.TanggalPesanan = ((DateOnly)reader["tanggal_pesanan"]).ToDateTime(TimeOnly.MinValue);
                    header.TotalHarga = Convert.ToDouble(reader["total_harga"]);
                    header.Status = Enum.Parse<Status>(reader["status_pesanan"].ToString(), true);
                    list.Add(header);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetPesananByStatus error: " + ex.Message);
                Debug.WriteLine("GetPesananByStatus error: " + ex);
            }
            return list;
        }

        public List<PesananHeader> GetAllPesanan()
        {
            var list = new List<PesananHeader>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                var sample = new PesananHeader();
                using var cmd = new NpgsqlCommand(
                    $"SELECT * FROM {sample.GetTableName()} ORDER BY tanggal_pesanan DESC", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var header = new PesananHeader();
                    header.Id = Convert.ToInt32(reader["id_pesanan"]);
                    header.IdPengguna = Convert.ToInt32(reader["id_pengguna"]);
                    header.TanggalPesanan = ((DateOnly)reader["tanggal_pesanan"]).ToDateTime(TimeOnly.MinValue);
                    header.TotalHarga = Convert.ToDouble(reader["total_harga"]);
                    header.Status = Enum.Parse<Status>(reader["status_pesanan"].ToString(), true);
                    list.Add(header);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetAllPesana error: " + ex.Message);
                Debug.WriteLine("GetAllPesana error: " + ex);
            }
            return list;
        }

        public DateTime? GetDeadlineBayar(int idPesanan)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT deadline_bayar FROM pembayaran WHERE id_pesanan = @id", conn);
                cmd.Parameters.AddWithValue("id", idPesanan);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    return Convert.ToDateTime(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("GetDeadlineBayar error: " + ex);
            }
            return null;
        }
    }
}

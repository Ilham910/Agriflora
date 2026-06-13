using Agriflora.Helpers;
using Agriflora.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Agriflora.Controllers
{
    public class LaporanController
    {
        // ─── Summary stats ───────────────────────────────────────

        public decimal GetPemasukanHariIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(total_harga), 0) FROM pesanan
                      WHERE tanggal_pesanan = CURRENT_DATE
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public int GetTransaksiHariIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COUNT(*) FROM pesanan
                      WHERE tanggal_pesanan = CURRENT_DATE
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public decimal GetPemasukanMingguIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(total_harga), 0) FROM pesanan
                      WHERE tanggal_pesanan >= date_trunc('week', CURRENT_DATE)
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public int GetTransaksiMingguIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COUNT(*) FROM pesanan
                      WHERE tanggal_pesanan >= date_trunc('week', CURRENT_DATE)
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public decimal GetPemasukanBulanIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(total_harga), 0) FROM pesanan
                      WHERE date_trunc('month', tanggal_pesanan) = date_trunc('month', CURRENT_DATE)
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public decimal GetPemasukanBulanLalu()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT COALESCE(SUM(total_harga), 0) FROM pesanan
                      WHERE date_trunc('month', tanggal_pesanan) = date_trunc('month', CURRENT_DATE - INTERVAL '1 month')
                      AND status_pesanan != 'MenungguPembayaran'", conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        // ─── Weekly breakdown for chart ──────────────────────────
        // Returns pemasukan per week of current month [W1, W2, W3, W4]
        public List<decimal> GetPemasukanPerMinggu()
        {
            var result = new List<decimal> { 0, 0, 0, 0 };
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT 
                        CEIL(EXTRACT(DAY FROM tanggal_pesanan) / 7.0) AS minggu,
                        COALESCE(SUM(total_harga), 0) AS total
                      FROM pesanan
                      WHERE date_trunc('month', tanggal_pesanan) = date_trunc('month', CURRENT_DATE)
                      AND status_pesanan != 'MenungguPembayaran'
                      GROUP BY minggu
                      ORDER BY minggu", conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int week = Convert.ToInt32(reader["minggu"]) - 1;
                    if (week >= 0 && week < 4)
                        result[week] = Convert.ToDecimal(reader["total"]);
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
            return result;
        }

        // ─── Produk terlaris ─────────────────────────────────────
        public List<(string NamaProduk, int TotalTerjual)> GetProdukTerlaris(int top = 4)
        {
            var result = new List<(string, int)>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.nama_produk, SUM(r.jumlah) AS total_terjual
                      FROM rincian_pesanan r
                      JOIN produk p ON r.id_produk = p.id_produk
                      JOIN pesanan ps ON r.id_pesanan = ps.id_pesanan
                      WHERE ps.status_pesanan != 'MenungguPembayaran'
                      GROUP BY p.nama_produk
                      ORDER BY total_terjual DESC
                      LIMIT @top", conn);
                cmd.Parameters.AddWithValue("top", top);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add((reader["nama_produk"].ToString(), Convert.ToInt32(reader["total_terjual"])));
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
            return result;
        }

        // ─── Riwayat transaksi for table ────────────────────────
        public List<RiwayatPesanan> GetRiwayatTransaksi()
        {
            var list = new List<RiwayatPesanan>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.id_pesanan, pg.nama_pengguna, p.tanggal_pesanan,
                             p.total_harga, p.status_pesanan,
                             STRING_AGG(pr.nama_produk || ' x' || r.jumlah, ', ') AS produk_list
                      FROM pesanan p
                      JOIN pengguna pg ON p.id_pengguna = pg.id_pengguna
                      JOIN rincian_pesanan r ON p.id_pesanan = r.id_pesanan
                      JOIN produk pr ON r.id_produk = pr.id_produk
                      GROUP BY p.id_pesanan, pg.nama_pengguna, p.tanggal_pesanan,
                               p.total_harga, p.status_pesanan
                      ORDER BY p.tanggal_pesanan DESC", conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RiwayatPesanan
                    {
                        IdPesanan = Convert.ToInt32(reader["id_pesanan"]),
                        NamaPengguna = reader["nama_pengguna"].ToString(),
                        Tanggal = ((DateOnly)reader["tanggal_pesanan"]).ToDateTime(TimeOnly.MinValue),
                        TotalHarga = Convert.ToDecimal(reader["total_harga"]),
                        Status = reader["status_pesanan"].ToString(),
                        ProdukList = reader["produk_list"].ToString()
                    });
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
            return list;
        }

        public int GetTotalProdukAktif()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM produk WHERE stok > 0", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public int GetTotalStok()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT COALESCE(SUM(stok), 0) FROM produk", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public int GetProdukHampirHabisCount()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM produk WHERE stok <= 5 AND stok > 0", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public int GetPesananMasukHariIni()
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM pesanan WHERE tanggal_pesanan = CURRENT_DATE", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Debug.WriteLine(ex); return 0; }
        }

        public List<Produk> GetProdukHampirHabis()
        {
            var list = new List<Produk>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.*, 
                             b.jenis_bunga, b.warna, b.deskripsi_bunga,
                             bi.jenis_tanaman, bi.deskripsi_bibit
                      FROM produk p
                      LEFT JOIN bunga b ON p.id_bunga = b.id_bunga
                      LEFT JOIN bibit bi ON p.id_bibit = bi.id_bibit
                      WHERE p.stok <= 5
                      ORDER BY p.stok ASC", conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bool isBunga = reader["id_bunga"] != DBNull.Value;
                    if (isBunga)
                    {
                        list.Add(new Bunga
                        {
                            IdProduk = Convert.ToInt32(reader["id_produk"]),
                            NamaProduk = reader["nama_produk"].ToString(),
                            Harga = Convert.ToDecimal(reader["harga"]),
                            Stok = Convert.ToInt32(reader["stok"]),
                            JenisBunga = reader["jenis_bunga"].ToString(),
                            Warna = reader["warna"].ToString()
                        });
                    }
                    else
                    {
                        list.Add(new Bibit
                        {
                            IdProduk = Convert.ToInt32(reader["id_produk"]),
                            NamaProduk = reader["nama_produk"].ToString(),
                            Harga = Convert.ToDecimal(reader["harga"]),
                            Stok = Convert.ToInt32(reader["stok"]),
                            JenisTanaman = reader["jenis_tanaman"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
            return list;
        }
    }
}


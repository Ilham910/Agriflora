using Agriflora.Helpers;
using Agriflora.Interfaces;
using Agriflora.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Agriflora.Controllers
{
    public class ProdukController : IProduk
    {
        // ─── PRODUK (base) ───────────────────────────────────────────

        // inserts into produk table, returns the generated id_produk
        private int InsertProduk(Produk produk, NpgsqlConnection conn)
        {
            using var cmd = new NpgsqlCommand(
                @"INSERT INTO produk (nama_produk, harga, stok, gambar)
              VALUES (@nama_produk, @harga, @stok, @gambar)
              RETURNING id_produk", conn); // RETURNING gives back the new ID

            cmd.Parameters.AddWithValue("nama_produk", produk.NamaProduk);
            cmd.Parameters.AddWithValue("harga", produk.Harga);
            cmd.Parameters.AddWithValue("stok", produk.Stok);
            cmd.Parameters.AddWithValue("gambar", produk.GambarProduk ?? (object)DBNull.Value);

            return Convert.ToInt32(cmd.ExecuteScalar()); // returns the new id_produk
        }

        public List<Produk> AmbilSemuaProduk()
        {
            var list = new List<Produk>();

            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Query 1 — Ambil semua bunga (joined dengan produk)
                using var cmdBunga = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                     p.id_bunga, b.jenis_bunga, b.warna, b.deskripsi_bunga
              FROM produk p
              JOIN bunga b ON p.id_bunga = b.id_bunga
              ORDER BY p.id_produk DESC", conn);

                using var readerBunga = cmdBunga.ExecuteReader();
                while (readerBunga.Read())
                {
                    list.Add(new Bunga
                    {
                        IdProduk = Convert.ToInt32(readerBunga["id_produk"]),
                        NamaProduk = readerBunga["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(readerBunga["harga"]),
                        Stok = Convert.ToInt32(readerBunga["stok"]),
                        GambarProduk = readerBunga["gambar"] as byte[],
                        IdBunga = Convert.ToInt32(readerBunga["id_bunga"]),
                        JenisBunga = readerBunga["jenis_bunga"].ToString(),
                        Warna = readerBunga["warna"].ToString(),
                        DeskripsiBunga = readerBunga["deskripsi_bunga"] as string
                    });
                }
                readerBunga.Close(); // harus ditutup sebelum pakai reader lain pada connection yang sama

                // Query 2 — ambil semua bibit (joined dengan produk)
                using var cmdBibit = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                     p.id_bibit, b.jenis_tanaman, b.deskripsi_bibit
              FROM produk p
              JOIN bibit b ON p.id_bibit = b.id_bibit
              ORDER BY p.id_produk DESC", conn);

                using var readerBibit = cmdBibit.ExecuteReader();
                while (readerBibit.Read())
                {
                    list.Add(new Bibit
                    {
                        IdProduk = Convert.ToInt32(readerBibit["id_produk"]),
                        NamaProduk = readerBibit["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(readerBibit["harga"]),
                        Stok = Convert.ToInt32(readerBibit["stok"]),
                        GambarProduk = readerBibit["gambar"] as byte[],
                        IdBibit = Convert.ToInt32(readerBibit["id_bibit"]),
                        JenisTanaman = readerBibit["jenis_tanaman"].ToString(),
                        DeskripsiBibit = readerBibit["deskripsi_bibit"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("AmbilSemuaProduk error: " + ex);
            }

            return list; // berisik produk campuran bunga + bibit, urutan berdasarkan id_produk DESC (terbaru dulu)
        }

        public Produk GetById(int id)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — cek apakah produk ini bunga atau bibit (atau tidak ada sama sekali)
                using var cmdCheck = new NpgsqlCommand(
                    @"SELECT id_bunga, id_bibit FROM produk WHERE id_produk = @id", conn);

                cmdCheck.Parameters.AddWithValue("id", id);

                using var reader = cmdCheck.ExecuteReader();
                if (!reader.Read()) return null;

                bool isBunga = reader["id_bunga"] != DBNull.Value;
                reader.Close();

                // Step 2 — ambil detail lengkap berdasarkan jenisnya (bunga atau bibit)
                if (isBunga)
                {
                    using var cmd = new NpgsqlCommand(
                        @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                         p.id_bunga, b.jenis_bunga, b.warna, b.deskripsi_bunga
                  FROM produk p
                  JOIN bunga b ON p.id_bunga = b.id_bunga
                  WHERE p.id_produk = @id", conn);

                    cmd.Parameters.AddWithValue("id", id);

                    using var reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        return new Bunga
                        {
                            IdProduk = Convert.ToInt32(reader1["id_produk"]),
                            NamaProduk = reader1["nama_produk"].ToString(),
                            Harga = Convert.ToDecimal(reader1["harga"]),
                            Stok = Convert.ToInt32(reader1["stok"]),
                            GambarProduk = reader1["gambar"] as byte[],
                            IdBunga = Convert.ToInt32(reader1["id_bunga"]),
                            JenisBunga = reader1["jenis_bunga"].ToString(),
                            Warna = reader1["warna"].ToString(),
                            DeskripsiBunga = reader1["deskripsi_bunga"] as string
                        };
                    }
                }
                else
                {
                    using var cmd = new NpgsqlCommand(
                        @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                         p.id_bibit, b.jenis_tanaman, b.deskripsi_bibit
                  FROM produk p
                  JOIN bibit b ON p.id_bibit = b.id_bibit
                  WHERE p.id_produk = @id", conn);

                    cmd.Parameters.AddWithValue("id", id);

                    using var reader2 = cmd.ExecuteReader();
                    if (reader2.Read())
                    {
                        return new Bibit
                        {
                            IdProduk = Convert.ToInt32(reader2["id_produk"]),
                            NamaProduk = reader2["nama_produk"].ToString(),
                            Harga = Convert.ToDecimal(reader2["harga"]),
                            Stok = Convert.ToInt32(reader2["stok"]),
                            GambarProduk = reader2["gambar"] as byte[],
                            IdBibit = Convert.ToInt32(reader2["id_bibit"]),
                            JenisTanaman = reader2["jenis_tanaman"].ToString(),
                            DeskripsiBibit = reader2["deskripsi_bibit"] as string
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("GetById error: " + ex);
                MessageBox.Show("Gagal mengambil data. Error: " + ex.Message);
            }

            return null;
        }

        public List<Produk> CariProduk(string keyword)
        {
            var list = new List<Produk>();

            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // search in bunga
                using var cmdBunga = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                     b.id_bunga, b.jenis_bunga, b.warna, b.deskripsi_bunga
              FROM produk p
              JOIN bunga b ON p.id_produk = b.id_produk
              WHERE LOWER(p.nama_produk) LIKE @keyword
                 OR LOWER(b.jenis_bunga) LIKE @keyword
                 OR LOWER(b.warna)       LIKE @keyword
              ORDER BY p.id_produk DESC", conn);

                cmdBunga.Parameters.AddWithValue("keyword", $"%{keyword.ToLower()}%");

                using var readerBunga = cmdBunga.ExecuteReader();
                while (readerBunga.Read())
                {
                    list.Add(new Bunga
                    {
                        IdProduk = Convert.ToInt32(readerBunga["id_produk"]),
                        NamaProduk = readerBunga["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(readerBunga["harga"]),
                        Stok = Convert.ToInt32(readerBunga["stok"]),
                        GambarProduk = readerBunga["gambar"] as byte[],
                        IdBunga = Convert.ToInt32(readerBunga["id_bunga"]),
                        JenisBunga = readerBunga["jenis_bunga"].ToString(),
                        Warna = readerBunga["warna"].ToString(),
                        DeskripsiBunga = readerBunga["deskripsi_bunga"] as string
                    });
                }
                readerBunga.Close();

                // search in bibit
                using var cmdBibit = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                     b.id_bibit, b.jenis_tanaman, b.deskripsi_bibit
              FROM produk p
              JOIN bibit b ON p.id_produk = b.id_produk
              WHERE LOWER(p.nama_produk)  LIKE @keyword
                 OR LOWER(b.jenis_tanaman) LIKE @keyword
              ORDER BY p.id_produk DESC", conn);

                cmdBibit.Parameters.AddWithValue("keyword", $"%{keyword.ToLower()}%");

                using var readerBibit = cmdBibit.ExecuteReader();
                while (readerBibit.Read())
                {
                    list.Add(new Bibit
                    {
                        IdProduk = Convert.ToInt32(readerBibit["id_produk"]),
                        NamaProduk = readerBibit["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(readerBibit["harga"]),
                        Stok = Convert.ToInt32(readerBibit["stok"]),
                        GambarProduk = readerBibit["gambar"] as byte[],
                        IdBibit = Convert.ToInt32(readerBibit["id_bibit"]),
                        JenisTanaman = readerBibit["jenis_tanaman"].ToString(),
                        DeskripsiBibit = readerBibit["deskripsi_bibit"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CariProduk error: " + ex);
            }

            return list;
        }

        // ─── BUNGA ───────────────────────────────────────────────────

        public bool TambahBunga(Bunga bunga)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — masukkan ke bunga dulu, dapatkan id_bunga yang di-generate
                using var cmdBunga = new NpgsqlCommand(
                    @"INSERT INTO bunga (jenis_bunga, warna, deskripsi_bunga)
                      VALUES (@jenis_bunga, @warna, @deskripsi)
                      RETURNING id_bunga", conn);
                cmdBunga.Parameters.AddWithValue("jenis_bunga", bunga.JenisBunga);
                cmdBunga.Parameters.AddWithValue("warna", bunga.Warna);
                cmdBunga.Parameters.AddWithValue("deskripsi", bunga.DeskripsiBunga ?? (object)DBNull.Value);
                int idBunga = Convert.ToInt32(cmdBunga.ExecuteScalar());

                // Step 2 — masukkan ke produk dengan id_bunga diisi, id_bibit null
                using var cmdProduk = new NpgsqlCommand(
                    @"INSERT INTO produk (nama_produk, harga, stok, gambar, id_bunga, id_bibit)
                      VALUES (@nama_produk, @harga, @stok, @gambar, @id_bunga, NULL)", conn);
                cmdProduk.Parameters.AddWithValue("nama_produk", bunga.NamaProduk);
                cmdProduk.Parameters.AddWithValue("harga", bunga.Harga);
                cmdProduk.Parameters.AddWithValue("stok", bunga.Stok);
                cmdProduk.Parameters.AddWithValue("gambar", bunga.GambarProduk ?? (object)DBNull.Value);
                cmdProduk.Parameters.AddWithValue("id_bunga", idBunga);
                cmdProduk.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("TambahBunga error: " + ex);
                MessageBox.Show("Gagal menyimpan bunga. Error: " + ex.Message);
                return false;
            }
        
        }

        public bool UpdateBunga(Bunga bunga)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — update produk
                using var cmdProduk = new NpgsqlCommand(
                    @"UPDATE produk SET nama_produk=@nama_produk, harga=@harga, 
                  stok=@stok, gambar=@gambar
                  WHERE id_produk=@id", conn);

                cmdProduk.Parameters.AddWithValue("id", bunga.IdProduk);
                cmdProduk.Parameters.AddWithValue("nama_produk", bunga.NamaProduk);
                cmdProduk.Parameters.AddWithValue("harga", bunga.Harga);
                cmdProduk.Parameters.AddWithValue("stok", bunga.Stok);
                cmdProduk.Parameters.AddWithValue("gambar", bunga.GambarProduk ?? (object)DBNull.Value);
                cmdProduk.ExecuteNonQuery();

                // Step 2 — update bunga
                using var cmdBunga = new NpgsqlCommand(
                    @"UPDATE bunga SET jenis_bunga=@jenis_bunga, warna=@warna, deskripsi_bunga=@deskripsi
                  WHERE id_bunga=@id_bunga", conn);

                cmdBunga.Parameters.AddWithValue("id_bunga", bunga.IdBunga);
                cmdBunga.Parameters.AddWithValue("jenis_bunga", bunga.JenisBunga);
                cmdBunga.Parameters.AddWithValue("warna", bunga.Warna);
                cmdBunga.Parameters.AddWithValue("deskripsi", bunga.DeskripsiBunga ?? (object)DBNull.Value);
                cmdBunga.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("UpdateBunga error: " + ex);
                MessageBox.Show("Gagal mengupdate bunga. Error: " + ex.Message);
                return false;
            }
        }

        public List<Bunga> AmbilSemuaBunga()
        {
            var list = new List<Bunga>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // JOIN produk + bunga untuk dapatkan semua info yang diperlukan sekaligus filter hanya yang id_bunga tidak null
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                         p.id_bunga, b.jenis_bunga, b.warna, b.deskripsi_bunga
                  FROM produk p
                  JOIN bunga b ON p.id_bunga = b.id_bunga
                  WHERE p.id_bunga IS NOT NULL
                  ORDER BY p.id_produk DESC", conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Bunga
                    {
                        IdProduk = Convert.ToInt32(reader["id_produk"]),
                        NamaProduk = reader["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(reader["harga"]),
                        Stok = Convert.ToInt32(reader["stok"]),
                        GambarProduk = reader["gambar"] as byte[],
                        IdBunga = Convert.ToInt32(reader["id_bunga"]),
                        JenisBunga = reader["jenis_bunga"].ToString(),
                        Warna = reader["warna"].ToString(),
                        DeskripsiBunga = reader["deskripsi_bunga"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("AmbilSemuaBunga error: " + ex);
            }
            return list;
        }

        // ─── BIBIT ───────────────────────────────────────────────────

        public bool TambahBibit(Bibit bibit)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — masukkan ke bibit dulu, dapatkan id_bibit yang di-generate
                using var cmdBibit = new NpgsqlCommand(
                    @"INSERT INTO bibit (jenis_tanaman, deskripsi_bibit)
                      VALUES (@jenis_tanaman, @deskripsi)
                      RETURNING id_bibit", conn);
                cmdBibit.Parameters.AddWithValue("jenis_tanaman", bibit.JenisTanaman);
                cmdBibit.Parameters.AddWithValue("deskripsi", bibit.DeskripsiBibit ?? (object)DBNull.Value);
                int idBibit = Convert.ToInt32(cmdBibit.ExecuteScalar());

                // Step 2 — masukkan ke produk dengan id_bibit diisi, id_bunga null
                using var cmdProduk = new NpgsqlCommand(
                    @"INSERT INTO produk (nama_produk, harga, stok, gambar, id_bunga, id_bibit)
                      VALUES (@nama_produk, @harga, @stok, @gambar, NULL, @id_bibit)", conn);
                cmdProduk.Parameters.AddWithValue("nama_produk", bibit.NamaProduk);
                cmdProduk.Parameters.AddWithValue("harga", bibit.Harga);
                cmdProduk.Parameters.AddWithValue("stok", bibit.Stok);
                cmdProduk.Parameters.AddWithValue("gambar", bibit.GambarProduk ?? (object)DBNull.Value);
                cmdProduk.Parameters.AddWithValue("id_bibit", idBibit);
                cmdProduk.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("TambahBibit error: " + ex);
                MessageBox.Show("Gagal menyimpan bibit. Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateBibit(Bibit bibit)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Step 1 — update produk
                using var cmdProduk = new NpgsqlCommand(
                    @"UPDATE produk SET nama_produk=@nama_produk, harga=@harga,
                  stok=@stok, gambar=@gambar
                  WHERE id_produk=@id", conn);

                cmdProduk.Parameters.AddWithValue("id", bibit.IdProduk);
                cmdProduk.Parameters.AddWithValue("nama_produk", bibit.NamaProduk);
                cmdProduk.Parameters.AddWithValue("harga", bibit.Harga);
                cmdProduk.Parameters.AddWithValue("stok", bibit.Stok);
                cmdProduk.Parameters.AddWithValue("gambar", bibit.GambarProduk ?? (object)DBNull.Value);
                cmdProduk.ExecuteNonQuery();

                // Step 2 — update bibit
                using var cmdBibit = new NpgsqlCommand(
                    @"UPDATE bibit SET jenis_tanaman=@jenis_tanaman, deskripsi_bibit=@deskripsi
                  WHERE id_bibit=@id_bibit", conn);

                cmdBibit.Parameters.AddWithValue("id_bibit", bibit.IdBibit);
                cmdBibit.Parameters.AddWithValue("jenis_tanaman", bibit.JenisTanaman);
                cmdBibit.Parameters.AddWithValue("deskripsi", bibit.DeskripsiBibit ?? (object)DBNull.Value);
                cmdBibit.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("UpdateBibit error: " + ex);
                MessageBox.Show("Gagal mengupdate bibit. Error: " + ex.Message);
                return false;
            }
        }

        public List<Bibit> AmbilSemuaBibit()
        {
            var list = new List<Bibit>();
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                using var cmd = new NpgsqlCommand(
                    @"SELECT p.id_produk, p.nama_produk, p.harga, p.stok, p.gambar,
                         p.id_bibit, b.jenis_tanaman, b.deskripsi_bibit
                  FROM produk p
                  JOIN bibit b ON p.id_bibit = b.id_bibit
                  WHERE p.id_bibit IS NOT NULL
                  ORDER BY p.id_produk DESC", conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Bibit
                    {
                        IdProduk = Convert.ToInt32(reader["id_produk"]),
                        NamaProduk = reader["nama_produk"].ToString(),
                        Harga = Convert.ToDecimal(reader["harga"]),
                        Stok = Convert.ToInt32(reader["stok"]),
                        GambarProduk = reader["gambar"] as byte[],
                        IdBibit = Convert.ToInt32(reader["id_bibit"]),
                        JenisTanaman = reader["jenis_tanaman"].ToString(),
                        DeskripsiBibit = reader["deskripsi_bibit"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("AmbilSemuaBibit error: " + ex);
            }
            return list;
        }

        public bool DeleteProduk(int idProduk)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                int? idBunga = null;
                int? idBibit = null;

                using var cmdGet = new NpgsqlCommand(
                    "SELECT id_bunga, id_bibit FROM produk WHERE id_produk = @id", conn);
                cmdGet.Parameters.AddWithValue("id", idProduk);

                using var reader = cmdGet.ExecuteReader();
                if (reader.Read())
                {
                    idBunga = reader["id_bunga"] as int?;
                    idBibit = reader["id_bibit"] as int?;
                }
                reader.Close();

                using var cmdProduk = new NpgsqlCommand(
                    "DELETE FROM produk WHERE id_produk = @id", conn);
                cmdProduk.Parameters.AddWithValue("id", idProduk);
                cmdProduk.ExecuteNonQuery();

                if (idBunga.HasValue)
                {
                    using var cmdBunga = new NpgsqlCommand(
                        "DELETE FROM bunga WHERE id_bunga = @id", conn);
                    cmdBunga.Parameters.AddWithValue("id", idBunga.Value);
                    cmdBunga.ExecuteNonQuery();
                }
                else if (idBibit.HasValue)
                {
                    using var cmdBibit = new NpgsqlCommand(
                        "DELETE FROM bibit WHERE id_bibit = @id", conn);
                    cmdBibit.Parameters.AddWithValue("id", idBibit.Value);
                    cmdBibit.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("DeleteProduk error: " + ex);
                MessageBox.Show("Gagal menghapus. Error: " + ex.Message);
                return false;
            }
        }
    }
}
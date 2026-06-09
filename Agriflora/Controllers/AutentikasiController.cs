using Agriflora.Helpers;
using Agriflora.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using static Agriflora.Models.Pengguna;

namespace Agriflora.Controllers
{
    public class AutentikasiController
    {
        public Pengguna Login(string email, string password)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                string query = @"SELECT id_pengguna, id_role, username_pengguna, password_pengguna, 
                                email_pengguna, nama_pengguna, alamat_pengguna, no_telp_pengguna
                         FROM pengguna
                         WHERE email_pengguna = @email AND password_pengguna = @password";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int role = reader.GetInt32(1);
                    string nama = reader.GetString(5);

                    // ── ABSTRACT + POLYMORPHISM: buat objek yang tepat
                    //    berdasarkan role dari database.
                    //    role == 1 → Customer, role == 2 → Florist
                    //    Keduanya adalah Pengguna, tapi punya perilaku berbeda.
                    Pengguna pengguna = role == 2
                        ? new Florist()
                        : new Customer();

                    pengguna.IdPengguna = reader.GetInt32(0);
                    pengguna.Role = role;
                    pengguna.Username = reader.GetString(2);
                    pengguna.Password = reader.GetString(3);
                    pengguna.Email = reader.GetString(4);
                    pengguna.Nama = nama;
                    pengguna.Alamat = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    pengguna.NoTelepon = reader.IsDBNull(7) ? "" : reader.GetString(7);

                    return pengguna;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error");
                return null;
            }
        }

        public bool Register(Pengguna pengguna)
        {
            try
            {
                if (IsEmailTaken(pengguna.Email))
                {
                    MessageBox.Show("Email sudah digunakan.", "Registrasi Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (IsUsernameTaken(pengguna.Username))
                {
                    MessageBox.Show("Username sudah digunakan.", "Registrasi Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                string query = @"INSERT INTO pengguna (id_role, username_pengguna, password_pengguna, 
                                               email_pengguna, nama_pengguna, alamat_pengguna, no_telp_pengguna)
                         VALUES (@id_role, @username, @password, @email, @nama, @alamat, @no_telp)";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id_role", pengguna.Role);
                cmd.Parameters.AddWithValue("username", pengguna.Username);
                cmd.Parameters.AddWithValue("password", pengguna.Password);
                cmd.Parameters.AddWithValue("email", pengguna.Email);
                cmd.Parameters.AddWithValue("nama", pengguna.Nama);
                cmd.Parameters.AddWithValue("alamat", pengguna.Alamat ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("no_telp", pengguna.NoTelepon ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Register error: {ex.Message}", "Error");
                return false;
            }
        }

        private bool IsEmailTaken(string email)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT COUNT(*) FROM pengguna WHERE email_pengguna = @email", conn);
            cmd.Parameters.AddWithValue("email", email);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool IsUsernameTaken(string username)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT COUNT(*) FROM pengguna WHERE username_pengguna = @username", conn);
            cmd.Parameters.AddWithValue("username", username);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}

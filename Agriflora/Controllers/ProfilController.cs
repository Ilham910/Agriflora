using Agriflora.Helpers;
using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Diagnostics;

namespace Agriflora.Controllers
{
    public class ProfilController
    {
        public bool UpdateProfil(Pengguna pengguna)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                using var cmdProfil = new NpgsqlCommand(
                    @"UPDATE pengguna SET nama_pengguna = @nama, email_pengguna = @email, alamat_pengguna = @alamat, no_telp_pengguna = @no_telepon, 
                    foto_profil = @foto_profil WHERE id_pengguna = @id_pengguna", conn);


                cmdProfil.Parameters.AddWithValue("@nama", pengguna.Nama);
                cmdProfil.Parameters.AddWithValue("@email", pengguna.Email);
                cmdProfil.Parameters.AddWithValue("@alamat", pengguna.Alamat);
                cmdProfil.Parameters.AddWithValue("@no_telepon", pengguna.NoTelepon);
                cmdProfil.Parameters.AddWithValue("@foto_profil", pengguna.FotoProfil ?? (object)DBNull.Value);
                cmdProfil.Parameters.AddWithValue("@id_pengguna", pengguna.IdPengguna);

                cmdProfil.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating profile: " + ex);
                MessageBox.Show("Error updating profile: " + ex.Message);
                return false;
            }
        }

        public bool UpdatePassword(Pengguna pengguna)
        {
            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();
                using var cmdPassword = new NpgsqlCommand(
                    @"UPDATE pengguna SET password_pengguna = @password WHERE id_pengguna = @id_pengguna", conn);
                cmdPassword.Parameters.AddWithValue("@password", pengguna.Password);
                cmdPassword.Parameters.AddWithValue("@id_pengguna", pengguna.IdPengguna);
                cmdPassword.ExecuteNonQuery();
                return true;
            }
            catch (ArgumentException ex)
            {
                // enkapsulasi: setter Password melempar ini jika < 6 karakter
                MessageBox.Show(ex.Message, "Validasi Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating password: " + ex);
                MessageBox.Show("Error updating password: " + ex.Message);
                return false;
            }
        }
    }
}

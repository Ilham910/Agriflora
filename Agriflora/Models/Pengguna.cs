using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Models
{
    public abstract class Pengguna
    {
        public int IdPengguna { get; set; }
        public string Nama { get; set; }
        public string Username { get; set; }
        public string Alamat { get; set; }
        public byte[] FotoProfil { get; set; }


        private string _email;
        private string _password;
        private string _noTelepon;
        public int _role;

        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@"))
                    throw new ArgumentException(
                      "Email tidak valid.");
                _email = value;
            }
        }


        public string Password
        {
            get => _password;
            set
            {
                try
                {
                    if (value.Length < 6)
                        throw new ArgumentException(
                          "Password min 6 karakter.");
                    _password = value;
                }
                catch (ArgumentException ex)
                {
                    // enkapsulasi: setter Password melempar ini jika < 6 karakter
                    MessageBox.Show(ex.Message, "Validasi Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }


        public string NoTelepon
        {
            get => _noTelepon;
            set
            {
                if (!value.All(char.IsDigit))
                    throw new ArgumentException(
                      "No. telepon hanya angka.");
                _noTelepon = value;
            }
        }

        public int Role
        {
            get => _role;
            set
            {
                if (value != 1 && value != 2)
                    throw new ArgumentException(
                      "Role hanya 1(admin) / 2(user).");
                _role = value;
            }
        }

        // ── Abstract method: setiap subclass WAJIB implementasikan ──
        // Mengembalikan label role untuk ditampilkan di UI
        public abstract string GetRole();

        // Mengembalikan nama Form/halaman utama sesuai role
        public abstract string GetHomePage();

        // Mengembalikan sapaan selamat datang yang berbeda per role
        public abstract string GetSapaan();

        // ── Non-abstract: shared oleh semua subclass ─────────────
        public string GetDisplayName()
        {
            return $"{Nama} ({GetRole()})";
        }

        // ── Customer: pengguna yang bisa browse & beli produk ────────
        public class Customer : Pengguna
        {
            public override string GetRole() => "Customer";

            public override string GetHomePage() => "HomePageCustomer";

            public override string GetSapaan()
                => $"Selamat datang, {Nama}! Temukan bunga & bibit favoritmu.";
        }

        // ── Florist: pengguna yang mengelola produk & pesanan ────────
        public class Florist : Pengguna
        {
            public override string GetRole() => "Florist";

            public override string GetHomePage() => "HomePageFlorist";

            public override string GetSapaan()
                => $"Halo, {Nama}! Kelola produk dan pesananmu di sini.";
        }

    }
}

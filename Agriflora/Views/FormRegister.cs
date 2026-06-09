using Agriflora.Controllers;
using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Agriflora.Models.Pengguna;

namespace Agriflora.Views
{
    public partial class FormRegister : Form
    {
        private AutentikasiController autentikasi = new AutentikasiController();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                string.IsNullOrWhiteSpace(tbNoTelepon.Text) ||
                cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Semua field harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ── ABSTRACT: tidak bisa new Pengguna() langsung.
            //    Buat subclass konkret sesuai role yang dipilih user.
            //    cbRole index 0 = Customer (role 1), index 1 = Florist (role 2)
            Pengguna penggunabaru = cbRole.SelectedIndex == 1
                ? new Florist()
                : new Customer();

            penggunabaru.Nama = tbNama.Text;
            penggunabaru.Email = tbEmail.Text;
            penggunabaru.Username = tbUsername.Text;
            penggunabaru.Password = tbPassword.Text;
            penggunabaru.Alamat = tbAlamat.Text;
            penggunabaru.NoTelepon = tbNoTelepon.Text;
            penggunabaru.Role = cbRole.SelectedIndex + 1;

            bool succes = autentikasi.Register(penggunabaru);

            if (succes)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new FormLogin().Show();

            }
            else
            {
                MessageBox.Show("Registrasi gagal. Pastikan username dan email belum digunakan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

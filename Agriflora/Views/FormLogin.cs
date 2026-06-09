using Agriflora.Controllers;
using Agriflora.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class FormLogin : Form
    {
        private AutentikasiController autentikasi = new AutentikasiController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Email dan password harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = tbEmail.Text;
            string password = tbPassword.Text;

            var pengguna = autentikasi.Login(email, password);

            if (pengguna != null)
            {
                AppSession.SetUser(pengguna);

                MessageBox.Show($"Login berhasil! Selamat datang, {pengguna.Nama}.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (pengguna.Role == 1) // Florist
                {
                    HomePageFlorist homePageFlorist = new HomePageFlorist();
                    homePageFlorist.Show();
                }
                else if (pengguna.Role == 2) // Customer
                {
                    HomePageCustomer homePageCustomer = new HomePageCustomer();
                    homePageCustomer.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal! Pastikan email dan password benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Clear();
                tbPassword.Clear();
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Select();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
            }
        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }
    }
}

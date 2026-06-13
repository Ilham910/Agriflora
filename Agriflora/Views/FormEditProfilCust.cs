using Agriflora.Controllers;
using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class FormEditProfilCust : Form
    {
        private ProfilController _controller = new ProfilController();
        private Pengguna _pengguna;

        public FormEditProfilCust(Pengguna pengguna)
        {
            InitializeComponent();
            _pengguna = pengguna;
            LoadData();
        }

        private void LoadData()
        {
            tbNama.Text = _pengguna.Nama;
            tbEmail.Text = _pengguna.Email;
            tbPassLama.Text = _pengguna.Password;
            tbAlamat.Text = _pengguna.Alamat;
            tbNoTelp.Text = _pengguna.NoTelepon;

            if (_pengguna.FotoProfil != null)
            {
                pictureBoxProfil.Image = Image.FromStream(new System.IO.MemoryStream(_pengguna.FotoProfil));
            }
        }

        private byte[] GetGambarBytes()
        {
            if (pictureBoxProfil.Image == null) return null;

            using var ms = new MemoryStream();
            pictureBoxProfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                string.IsNullOrWhiteSpace(tbNoTelp.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pengguna.Nama = tbNama.Text.Trim();
            _pengguna.Email = tbEmail.Text.Trim();
            _pengguna.Alamat = tbAlamat.Text.Trim();
            _pengguna.NoTelepon = tbNoTelp.Text.Trim();
            _pengguna.FotoProfil = GetGambarBytes();

            bool success = _controller.UpdateProfil(_pengguna);

            if (success)
            {
                MessageBox.Show("Profil berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal memperbarui profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GantiProfil_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Silahkan Pilih Gambar Profil";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxProfil.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxProfil.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

            LoadData();
        }

        private void btnGantiPass_Click(object sender, EventArgs e)
        {
            if (tbPassBaru.Text != tbKonfirmPass.Text)
            {
                MessageBox.Show("Password baru tidak cocok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbPassBaru.Text == tbKonfirmPass.Text && tbKonfirmPass.Text == _pengguna.Password)
            {
                MessageBox.Show("Password baru tidak boleh sama dengan password lama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _pengguna.Password = tbPassBaru.Text.Trim();
            }
            catch (ArgumentException ex)
            {
                // enkapsulasi: setter Password melempar ini jika < 6 karakter
                MessageBox.Show(ex.Message, "Validasi Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool success = _controller.UpdatePassword(_pengguna);

            if (success)
            {
                MessageBox.Show("Password berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Gagal memperbarui password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            LoadData();
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            new HomePageCustomer().Show();
            this.Close();
        }
    }
}

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
    public partial class FormUpdateBunga : Form
    {
        private ProdukController _controller = new ProdukController();
        private Bunga _bunga;
        public FormUpdateBunga(Bunga bunga)
        {
            InitializeComponent();
            _bunga = bunga;
            LoadData();
        }

        private void LoadData()
        {
            tbNama.Text = _bunga.NamaProduk;
            tbHarga.Text = _bunga.Harga.ToString();
            tbStok.Text = _bunga.Stok.ToString();
            tbJenis.Text = _bunga.JenisBunga;
            tbWarna.Text = _bunga.Warna;
            tbDeskripsi.Text = _bunga.DeskripsiBunga;

            // show existing image if available
            if (_bunga.GambarProduk != null)
            {
                pictureBoxGambar.Image = Image.FromStream(new MemoryStream(_bunga.GambarProduk));
            }
        }

        private byte[] GetGambarBytes()
        {
            if (pictureBoxGambar.Image == null) return null;

            using var ms = new MemoryStream();
            pictureBoxGambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxGambar.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;
                    btnUpload.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
           string.IsNullOrWhiteSpace(tbHarga.Text) ||
           string.IsNullOrWhiteSpace(tbStok.Text))
            {
                MessageBox.Show("Nama, harga, dan stok wajib diisi.");
                return;
            }

            if (!decimal.TryParse(tbHarga.Text, out decimal harga))
            {
                MessageBox.Show("Harga tidak valid.");
                return;
            }

            if (!int.TryParse(tbStok.Text, out int stok))
            {
                MessageBox.Show("Stok tidak valid.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbJenis.Text))
            {
                MessageBox.Show("Jenis tanaman wajib diisi.");
                return;
            }

            _bunga.NamaProduk = tbNama.Text.Trim();
            _bunga.Harga = harga;
            _bunga.Stok = stok;
            _bunga.JenisBunga = tbJenis.Text.Trim();
            _bunga.DeskripsiBunga = tbDeskripsi.Text.Trim();
            _bunga.Warna = tbWarna.Text.Trim();
            _bunga.GambarProduk = GetGambarBytes();

            bool success = _controller.UpdateBunga(_bunga);

            if (success)
            {
                MessageBox.Show("Bunga berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

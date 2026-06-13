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
    public partial class FormUpdateBibit : Form
    {
        private ProdukController _controller = new ProdukController();
        private Bibit _bibit;
        public FormUpdateBibit(Bibit bibit)
        {
            InitializeComponent();
            _bibit = bibit;
            LoadData();
        }

        private void LoadData()
        {
            tbNama.Text = _bibit.NamaProduk;
            tbHarga.Text = _bibit.Harga.ToString();
            tbStok.Text = _bibit.Stok.ToString();
            tbJenis.Text = _bibit.JenisTanaman;
            tbDeskripsi.Text = _bibit.DeskripsiBibit;

            // show existing image if available
            if (_bibit.GambarProduk != null)
            {
                pictureBoxGambar.Image = Image.FromStream(new MemoryStream(_bibit.GambarProduk));
            }
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

        private byte[] GetGambarBytes()
        {
            if (pictureBoxGambar.Image == null) return null;

            using var ms = new MemoryStream();
            pictureBoxGambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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

            _bibit.NamaProduk = tbNama.Text.Trim();
            _bibit.Harga = harga;
            _bibit.Stok = stok;
            _bibit.JenisTanaman = tbJenis.Text.Trim();
            _bibit.DeskripsiBibit = tbDeskripsi.Text.Trim();
            _bibit.GambarProduk = GetGambarBytes();

            bool success = _controller.UpdateBibit(_bibit);

            if (success)
            {
                MessageBox.Show("Bibit berhasil diperbarui!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pictureBoxGambar_Click(object sender, EventArgs e)
        {

        }

        private void tbDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

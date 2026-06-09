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
    public partial class FormTambahProduk : Form
    {
        private ProdukController _controller = new ProdukController();
        public FormTambahProduk()
        {
            InitializeComponent();

            radioBunga.Checked = true;
            panelBunga.Visible = true;
            panelBibit.Visible = false;

            // toggle panel saat radio berubah
            radioBunga.CheckedChanged += (s, e) =>
            {
                panelBunga.Visible = radioBunga.Checked;
                panelBibit.Visible = !radioBunga.Checked;
            };
        }

        private void btUploadTambahGambar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxTambahGambar.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxTambahGambar.SizeMode = PictureBoxSizeMode.Zoom;
                    btUploadTambahGambar.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private byte[] GetGambarBytes()
        {
            if (pictureBoxTambahGambar.Image == null) return null;

            using var ms = new MemoryStream();
            pictureBoxTambahGambar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
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

            bool success;

            if (radioBunga.Checked)
            {
                // validasi field bunga
                if (string.IsNullOrWhiteSpace(tbJenisBunga.Text) ||
                    string.IsNullOrWhiteSpace(tbWarna.Text))
                {
                    MessageBox.Show("Jenis bunga dan warna wajib diisi.");
                    return;
                }

                var bunga = new Bunga
                {
                    NamaProduk = tbNama.Text.Trim(),
                    Harga = harga,
                    Stok = stok,
                    GambarProduk = GetGambarBytes(),
                    JenisBunga = tbJenisBunga.Text.Trim(),
                    Warna = tbWarna.Text.Trim(),
                    DeskripsiBunga = string.IsNullOrWhiteSpace(tbDeskripsiBunga.Text)
                                     ? null : tbDeskripsiBunga.Text.Trim()
                };

                success = _controller.TambahBunga(bunga);
            }
            else
            {
                // validasi field bibit
                if (string.IsNullOrWhiteSpace(tbJenisTanaman.Text))
                {
                    MessageBox.Show("Jenis tanaman wajib diisi.");
                    return;
                }

                var bibit = new Bibit
                {
                    NamaProduk = tbNama.Text.Trim(),
                    Harga = harga,
                    Stok = stok,
                    GambarProduk = GetGambarBytes(),
                    JenisTanaman = tbJenisTanaman.Text.Trim(),
                    DeskripsiBibit = string.IsNullOrWhiteSpace(tbDeskripsiBibit.Text)
                                     ? null : tbDeskripsiBibit.Text.Trim()
                };

                success = _controller.TambahBibit(bibit);
            }

            if (success)
            {
                MessageBox.Show("Produk berhasil disimpan.");
                DialogResult = DialogResult.OK; // trigger LoadCards() di parent
                Close();
            }
        }
    }
}

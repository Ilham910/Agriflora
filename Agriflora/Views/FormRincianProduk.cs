using Agriflora.Controllers;
using Agriflora.Helpers;
using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class FormRincianProduk : Form
    {
        private Produk _produk;
        private KeranjangController _controller;
        private int _quantity = 1; // default quantity
        public FormRincianProduk(Produk produk)
        {
            InitializeComponent();
            _produk = produk;
            _controller = KeranjangHelper.Keranjang;
            LoadDetail();
            RefreshQuantityDisplay();
        }

        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            if (File.Exists(path))
                pictureBoxGambar.Image = Image.FromFile(path);
        }

        private void LoadDetail()
        {
            lblNama.Text = _produk.NamaProduk;
            lblHarga.Text = $"Rp {_produk.Harga:N0}";
            if (_produk.GambarProduk != null)
            {
                try
                {
                    using var ms = new MemoryStream(_produk.GambarProduk);
                    pictureBoxGambar.Image = Image.FromStream(ms);
                }
                catch { LoadPlaceholder(); }
            }
            else
            {
                LoadPlaceholder();
            }

            if (_produk is Bunga bunga)
            {
                PanelBibit.Visible = false;
                tbDeskripsi.Text = bunga.DeskripsiBunga;
            }
            else if (_produk is Bibit bibit)
            {
                PanelBibit.Visible = true;
                lblJenisTanaman.Text = bibit.JenisTanaman;
                tbDeskripsi.Text = bibit.DeskripsiBibit;
            }
        }

        private void RefreshQuantityDisplay()
        {
            lblKuantitas.Text = _quantity.ToString();

            // matikan minus jika quantity 1 (tidak boleh kurang dari 1)
            btnKurang.Enabled = _quantity > 1;

            // matikan plus jika quantity mencapai batas stok
            btnTambah.Enabled = _quantity < _produk.Stok;

            // ── OVERLOADING: HitungTotal(int) — subtotal tanpa diskon
            decimal subtotal = _produk.HitungTotal(_quantity);
            lblSubtotal.Text = $"Subtotal: Rp {subtotal:N0}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblJenisTanaman_Click(object sender, EventArgs e)
        {

        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            _controller.AddToCart(_produk, _quantity);

            // ── OVERLOADING: HitungTotal(int) dipakai untuk pesan konfirmasi
            decimal totalDitambah = _produk.HitungTotal(_quantity);

            MessageBox.Show(
               $"{_produk.NamaProduk} x{_quantity} ditambahkan ke keranjang!\n" +
               $"Subtotal: Rp {totalDitambah:N0}\n" +
               $"Total keranjang: {_controller.GetTotalItems()} item",
               "Berhasil",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (_quantity <= 1) return; // minimum 1

            _quantity--;
            RefreshQuantityDisplay();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (_quantity >= _produk.Stok)
            {
                MessageBox.Show($"Stok hanya tersedia {_produk.Stok}.", "Stok Habis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _quantity++;
            RefreshQuantityDisplay();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKeranjang().Show();
        }
    }
}

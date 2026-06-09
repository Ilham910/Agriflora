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
    public partial class ProdukCard : UserControl
    {
        public event EventHandler UbahClicked;
        public event EventHandler HapusClicked;

        public Produk CurrentProduk { get; private set; }

        public int IdProduk { get; private set; }

        public ProdukCard()
        {
            InitializeComponent();
        }

        public void SetProdukInfo(Produk produk, Image placeholder)
        {
            IdProduk = produk.IdProduk;
            CurrentProduk = produk;
            lblNama.Text = produk.NamaProduk;
            lblHarga.Text = $"Rp {produk.Harga:N0}";
            lblKuantitas.Text = $"{produk.Stok}";

            // ── OVERRIDING: GetJenisProduk() dipanggil lewat referensi Produk,
            //    tapi yang dieksekusi adalah versi Bunga atau Bibit (runtime polymorphism)
            lblJenis.Text = produk.GetJenisProduk();


            // ── OVERRIDING: GetDeskripsiSingkat() tiap subclass punya format sendiri
            toolTip1.SetToolTip(this, produk.GetDeskripsiSingkat());


            if (produk.GambarProduk != null)
            {
                try
                {
                    using var ms = new MemoryStream(produk.GambarProduk);
                    pictureBoxGambar.Image = Image.FromStream(ms);
                    pictureBoxGambar.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch { pictureBoxGambar.Image = placeholder; }
            }
            else
            {
                pictureBoxGambar.Image = placeholder;
                pictureBoxGambar.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (produk.Stok <= 0)
            {
                lblHabis.Visible = true;
                lblTersedia.Visible = false;
            }
            else
            {
                lblHabis.Visible = false;
                lblTersedia.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            UbahClicked?.Invoke(this, e);
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            HapusClicked?.Invoke(this, e);
        }
    }
}

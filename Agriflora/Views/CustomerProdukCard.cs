using Agriflora.Interfaces;
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
    public partial class CustomerProdukCard : UserControl
    {
        public event EventHandler MasukClicked;
        public event EventHandler DetailBungaClicked;

        public Produk CurrentProduk { get; private set; }

        public int IdProduk { get; private set; }

        public CustomerProdukCard()
        {
            InitializeComponent();
        }

        public void SetProdukInfo(Produk produk, Image placeholder)
        {
            IdProduk = produk.IdProduk;
            CurrentProduk = produk;

            // ── OVERRIDING: GetDeskripsiSingkat() tampilkan info spesifik
            //    Bunga → sertakan warna, Bibit → sertakan jenis tanaman
            lblDesk.Text = produk.GetDeskripsiSingkat();

            


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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            MasukClicked?.Invoke(this, e);
        }

        private void pictureBoxGambar_Click(object sender, EventArgs e)
        {
            DetailBungaClicked?.Invoke(this, e);
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ProdukHampirHabisCard : UserControl
    {
        public ProdukHampirHabisCard()
        {
            InitializeComponent();
        }

        public void SetData(Produk produk)
        {
            lblNama.Text = produk.NamaProduk;
            lblStok.Text = $"{produk.Stok} Item";

            if (produk.Stok == 0)
            {
                lblStatusStok.Text = "Habis";
                lblStatusStok.ForeColor = Color.FromArgb(163, 45, 45);
                lblStatusStok.BackColor = Color.FromArgb(255, 220, 220);
            }
            else
            {
                lblStatusStok.Text = "Hampir Habis";
                lblStatusStok.ForeColor = Color.FromArgb(133, 79, 11);
                lblStatusStok.BackColor = Color.FromArgb(255, 237, 200);
            }
        }
    }
}

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
    public partial class ItemPesananCard : UserControl
    {
        public ItemPesananCard()
        {
            InitializeComponent();
        }

        public void SetData(RincianPesanan item, Image placeholder)
        {
            // image
            if (item.Gambar != null)
            {
                try
                {
                    using var ms = new MemoryStream(item.Gambar);
                    pictureBoxGambar.Image = Image.FromStream(ms);
                }
                catch { pictureBoxGambar.Image = placeholder; }
            }
            else
            {
                pictureBoxGambar.Image = placeholder;
            }


            lblNama.Text = $"{item.NamaProduk} x {item.Quantity}";

            lblHarga.Text = $"{item.Harga.ToString("C0", new CultureInfo("id-ID"))}/item";

        }
    }
}

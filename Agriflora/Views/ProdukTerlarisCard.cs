using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class ProdukTerlarisCard : UserControl
    {
        public ProdukTerlarisCard()
        {
            InitializeComponent();
        }

        public void SetData(string namaProduk, int terjual, int maxTerjual, Color barColor)
        {
            lblNama.Text = namaProduk;

            // calculate bar width proportionally
            int maxBarWidth = pnlBarBg.Width;
            int barWidth = maxTerjual > 0
                ? (int)((double)terjual / maxTerjual * maxBarWidth)
                : 0;

            pnlBar.Width = barWidth;
            pnlBar.BackColor = barColor;
        }
    }
}

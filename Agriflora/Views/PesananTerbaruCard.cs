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
    public partial class PesananTerbaruCard : UserControl
    {
        private PesananHeader _pesanan;

        public PesananTerbaruCard()
        {
            InitializeComponent();
        }

        public void SetPesanan(PesananHeader pesanan)
        {
            _pesanan = pesanan;

            lblId.Text = $"ID : {pesanan.Id}";   
            lblStatus.Text = $"{FormatStatus(pesanan.Status)}";
        }

        private string FormatStatus(Status s)
        {
            switch (s)
            {
                case Status.MenungguPembayaran: return "Menunggu";
                case Status.Diproses: return "Diproses";
                case Status.SiapDiambil: return "Siap Ambil";
                case Status.Diambil: return "Diambil";
                case Status.Selesai: return "Selesai";
                default: return s.ToString();
            }
        }

        //private Color GetStatusColor(Status s)
        //{
        //    switch (s)
        //    {
        //        case Status.MenungguPembayaran: return Color.FromArgb(200, 120, 0);
        //        case Status.Diproses: return Color.FromArgb(60, 52, 137);
        //        case Status.SiapDiambil: return Color.FromArgb(8, 80, 65);
        //        case Status.Diambil: return Color.FromArgb(12, 68, 124);
        //        case Status.Selesai: return Color.FromArgb(59, 109, 17);
        //        default: return Color.Black;
        //    }
        //}
    }
}

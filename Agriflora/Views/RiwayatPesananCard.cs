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
    public partial class RiwayatPesananCard : UserControl
    {
        public RiwayatPesananCard()
        {
            InitializeComponent();
        }

        private readonly List<string> _statusSteps = new List<string>
        {
            Status.MenungguPembayaran.ToString(),
            Status.Diproses.ToString(),
            Status.SiapDiambil.ToString(),
            Status.Diambil.ToString(),
            Status.Selesai.ToString()
        };


        public void setData(PesananHeader pesananHeader, RincianPesanan rincianPesanan, Image placeholder)
        {
            if (rincianPesanan.Gambar != null)
            {
                try
                {
                    using var ms = new MemoryStream(rincianPesanan.Gambar);
                    pictureBoxGambar.Image = Image.FromStream(ms);
                }
                catch { pictureBoxGambar.Image = placeholder; }
            }
            else
            {
                pictureBoxGambar.Image = placeholder;
            }


            lblNama.Text = rincianPesanan.NamaProduk;
            lblHarga.Text = $"Rp {rincianPesanan.Harga:N0} x {rincianPesanan.Quantity}";
            lblId.Text = $"ID Pesanan: {pesananHeader.IdPesanan}";
            lblStatus.Text = pesananHeader.Status.ToString();
            lblTanggal.Text = pesananHeader.TanggalPesanan.ToString("dd MMMM yyyy");
            lblTotal.Text = $"Rp. {pesananHeader.TotalHarga:N0}";

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

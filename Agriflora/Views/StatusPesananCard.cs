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
    public partial class StatusPesananCard : UserControl
    {
        private PesananController _controller = new PesananController();
        private Image _placeholder;

        private readonly List<string> _statusSteps = new List<string>
        {
            Status.MenungguPembayaran.ToString(),
            Status.Diproses.ToString(),
            Status.SiapDiambil.ToString(),
            Status.Diambil.ToString(),
            Status.Selesai.ToString()
        };
        public StatusPesananCard()
        {
            InitializeComponent();
        }


        public void SetData(PesananHeader pesanan)
        {
            var rincianList = _controller.GetRincianByPesanan(pesanan.IdPesanan);
            int currentStep = (int)pesanan.Status;

            lblIdPesanan.Text = $"ID Pesanan: {pesanan.IdPesanan}";
            lblTanggal.Text = $"{pesanan.TanggalPesanan:dd MMM yyyy} · {rincianList.Count} produk";
            lblStatus.Text = pesanan.Status.ToString();

            LoadItems(rincianList);

        }

        private void LoadItems(List<RincianPesanan> rincianList)
        {
            flowItemPesanan.Controls.Clear();

            foreach (var item in rincianList)
            {
                var row = new ItemPesananCard();
                row.SetData(item, _placeholder);
                flowItemPesanan.Controls.Add(row);
            }
        }
    }
}

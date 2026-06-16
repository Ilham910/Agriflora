using Agriflora.Controllers;
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
    public partial class PesananRowCard : UserControl
    {
        public event EventHandler AksiClicked;
        private PesananHeader _pesanan;
        private PesananController _controller = new PesananController();

        public PesananRowCard()
        {
            InitializeComponent();
        }

        public void SetData(PesananHeader pesanan, string namaPengguna, string produkList)
        {
            _pesanan = pesanan;

            lblId.Text = $"ID Pesanan : {pesanan.IdPesanan}";
            lblCustomer.Text = namaPengguna;
            lblProduk.Text = produkList;
            lblTotal.Text = ((decimal)pesanan.TotalHarga).ToString("C0", new CultureInfo("id-ID"));
            lblTanggal.Text = pesanan.TanggalPesanan.ToString("dd MMM yyyy");

            // status text and color
            lblStatus.Text = FormatStatus(pesanan.Status);
            lblStatus.ForeColor = GetStatusColor(pesanan.Status);

            // aksi button text = next status
            btnAksi.Text = GetNextStatusLabel(pesanan.Status);
            btnAksi.Enabled = pesanan.Status != Status.Selesai;
        }

        private Status? GetNextStatus(Status current)
        {
            switch (current)
            {
                case Status.MenungguPembayaran: return Status.Diproses;
                case Status.Diproses: return Status.SiapDiambil;
                case Status.SiapDiambil: return Status.Diambil;
                case Status.Diambil: return Status.Selesai;
                default: return null;
            }
        }

        private string GetNextStatusLabel(Status current)
        {
            var next = GetNextStatus(current);
            return next == null ? "Selesai" : FormatStatus(next.Value);
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

        private Color GetStatusColor(Status s)
        {
            switch (s)
            {
                case Status.MenungguPembayaran: return Color.FromArgb(200, 120, 0);
                case Status.Diproses: return Color.FromArgb(60, 52, 137);
                case Status.SiapDiambil: return Color.FromArgb(8, 80, 65);
                case Status.Diambil: return Color.FromArgb(12, 68, 124);
                case Status.Selesai: return Color.FromArgb(59, 109, 17);
                default: return Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAksi_Click_1(object sender, EventArgs e)
        {
            Status? next = GetNextStatus(_pesanan.Status);
            if (next == null) return;

            var konfirmasi = MessageBox.Show(
                $"Update pesanan #AGF-{_pesanan.IdPesanan} ke '{FormatStatus(next.Value)}'?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                bool ok = _controller.UpdateStatus(_pesanan, next.Value);
                if (ok)
                {
                    lblStatus.Text = FormatStatus(next.Value);
                    lblStatus.ForeColor = GetStatusColor(next.Value);
                    btnAksi.Text = GetNextStatusLabel(next.Value);
                    btnAksi.Enabled = next.Value != Status.Selesai;
                    _pesanan.Status = next.Value;

                    AksiClicked?.Invoke(this, e);
                }
            }
        }
    }
}

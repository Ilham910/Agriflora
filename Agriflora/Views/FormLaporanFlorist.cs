using Agriflora.Controllers;
using Agriflora.Helpers;
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
    public partial class FormLaporanFlorist : Form
    {
        private LaporanController _controller = new LaporanController();
        public FormLaporanFlorist()
        {
            InitializeComponent();
            LoadLaporan();
            LoadUserInfo();
        }


        private void LoadLaporan()
        {
            var culture = new CultureInfo("id-ID");

            // ── Month label ──
            lblBulan.Text = DateTime.Now.ToString("MMMM yyyy", new CultureInfo("id-ID"));

            lblHariIni.Text = _controller.GetPemasukanHariIni().ToString("C0", culture);
            lblInfoHariIni.Text = $"{_controller.GetTransaksiHariIni()} transaksi";

            lblMingguIni.Text = _controller.GetPemasukanMingguIni().ToString("C0", culture);
            lblInfoMingguIni.Text = $"{_controller.GetTransaksiMingguIni()} transaksi";

            decimal bulanIni = _controller.GetPemasukanBulanIni();
            decimal bulanLalu = _controller.GetPemasukanBulanLalu();
            string infoText = bulanLalu > 0
                ? (bulanIni >= bulanLalu
                    ? $"naik {((bulanIni - bulanLalu) / bulanLalu * 100):F0}% dari bulan lalu"
                    : $"turun {((bulanLalu - bulanIni) / bulanLalu * 100):F0}% dari bulan lalu")
                : "tidak ada data bulan lalu";

            lblBulanIni.Text = bulanIni.ToString("C0", culture);
            lblInfoBulanIni.Text = infoText;


            // ── Produk terlaris ──
            LoadProdukTerlaris();

            //// ── Riwayat transaksi ──
            //LoadRiwayatTransaksi();
        }


        // ─── Produk Terlaris ─────────────────────────────────────
        // flowProdukTerlaris = FlowLayoutPanel in designer
        private void LoadProdukTerlaris()
        {
            flowProdukTerlaris.Controls.Clear();

            var data = _controller.GetProdukTerlaris(4);
            if (data.Count == 0) return;

            int maxVal = 0;
            foreach (var d in data) if (d.TotalTerjual > maxVal) maxVal = d.TotalTerjual;

            var colors = new[]
            {
                Color.FromArgb(163, 60, 90),
                Color.FromArgb(80, 160, 100),
                Color.FromArgb(120, 80, 160),
                Color.FromArgb(60, 120, 180)
            };

            for (int i = 0; i < data.Count; i++)
            {
                var card = new ProdukTerlarisCard();
                card.SetData(data[i].NamaProduk, data[i].TotalTerjual, maxVal, colors[i % colors.Length]);
                card.Width = flowProdukTerlaris.Width - 4;
                flowProdukTerlaris.Controls.Add(card);
            }
        }

        private void LoadUserInfo()
        {
            var user = AppSession.CurrentUser;
            if (user != null)
            {
                lblNamaUser.Text = user.Nama;
                lblEmailUser.Text = user.Email;
                lblNoTelp.Text = user.NoTelepon;
            }
        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDashboardFlorist().Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePageFlorist().Show();
        }

        private void lblPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPesananFlorist().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }
    }
}

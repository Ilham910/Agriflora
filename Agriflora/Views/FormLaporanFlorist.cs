using Agriflora.Controllers;
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

            //// ── Chart ──
            //DrawGrafik();

            //// ── Produk terlaris ──
            //LoadProdukTerlaris();

            //// ── Riwayat transaksi ──
            //LoadRiwayatTransaksi();
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
    }
}

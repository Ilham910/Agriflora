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
    public partial class FormDashboardFlorist : Form
    {
        private LaporanController _laporan = new LaporanController();
        private PesananController _pesanan = new PesananController();

        public FormDashboardFlorist()
        {
            InitializeComponent();
            LoadDashboard();
            LoadUserInfo();
        }



        public void LoadDashboard()
        {
            var culture = new CultureInfo("id-ID");

            lblProdukAktif.Text = _laporan.GetTotalProdukAktif().ToString();
            lblInfoProduk.Text = $"{_laporan.GetProdukHampirHabisCount()} hampir habis stok";

            lblMasuk.Text = _laporan.GetPesananMasukHariIni().ToString();
            lblInfoMasuk.Text = $"{_laporan.GetPesananMasukHariIni()} pesanan baru hari ini";

            lblTotalStok.Text = _laporan.GetTotalStok().ToString();


            decimal bulanIni = _laporan.GetPemasukanBulanIni();
            decimal bulanLalu = _laporan.GetPemasukanBulanLalu();
            string infoText = bulanLalu > 0
                ? (bulanIni >= bulanLalu
                    ? $"naik {((bulanIni - bulanLalu) / bulanLalu * 100):F0}% dari bulan lalu"
                    : $"turun {((bulanLalu - bulanIni) / bulanLalu * 100):F0}% dari bulan lalu")
                : "tidak ada data bulan lalu";

            lblPemasukan.Text = bulanIni.ToString("C0", culture);
            lblInfoPemasukan.Text = infoText;

            // pesanan terbaru
            //LoadPesananTerbaru();

            // produk hampir habis
            LoadProdukHampirHabis();
            LoadPesananTerbaru();
        }

        private void LoadPesananTerbaru()
        {
            // flowPesanan = FlowLayoutPanel di designer
            flowPesananTerbaru.Controls.Clear();
            var list = _pesanan.GetAllPesanan();
            foreach (var p in list.Take(2))
            {
                var card = new PesananTerbaruCard();
                card.SetPesanan(p);
                card.Width = flowPesananTerbaru.Width - 4;
                flowPesananTerbaru.Controls.Add(card);
            }
        }

        private void LoadProdukHampirHabis()
        {
            // flowHampirHabis = FlowLayoutPanel in designer
            flowHampirHabis.Controls.Clear();

            var list = _laporan.GetProdukHampirHabis();
            foreach (var p in list)
            {
                var card = new ProdukHampirHabisCard();
                card.SetData(p);
                card.Width = flowHampirHabis.Width - 4;
                flowHampirHabis.Controls.Add(card);
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


        private void FormDashboardFlorist_Load(object sender, EventArgs e)
        {

        }

        private void lblKelProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePageFlorist().Show();
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

        private void lblPemasukan_Click(object sender, EventArgs e)
        {

        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLaporanFlorist().Show();
        }

        private void lblLihatPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPesananFlorist().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        //private void btnLihatPesanan_Click(object sender, EventArgs e)
        //{
        //    new FormPesananFlorist().Show();
        //    this.Hide();
        //}
    }
}

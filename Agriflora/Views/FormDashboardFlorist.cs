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
        }



        public void LoadDashboard()
        {
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

            lblPemasukan.Text = $"Rp {bulanIni:N0}";
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

        private string GetNamaPengguna(int id)
        {
            try
            {
                using var conn = Agriflora.Helpers.DatabaseHelper.GetConnection();
                conn.Open();
                using var cmd = new Npgsql.NpgsqlCommand(
                    "SELECT nama_pengguna FROM pengguna WHERE id_pengguna = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                return cmd.ExecuteScalar()?.ToString() ?? "-";
            }
            catch { return "-"; }
        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);

        //    // 0x0085 is WM_NCPAINT, which triggers the non-client area (borders/scrollbars) to draw
        //    if (m.Msg == 0x0085)
        //    {
        //        // Hides both vertical and horizontal scroll bars for flowLayoutPanel1
        //        ShowScrollBar(flowLayoutPanel1.Handle, SB_BOTH, false);
        //    }
        //}


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

        //private void btnLihatPesanan_Click(object sender, EventArgs e)
        //{
        //    new FormPesananFlorist().Show();
        //    this.Hide();
        //}
    }
}

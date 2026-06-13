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
    public partial class HomePageFlorist : Form
    {
        // ─── Controller ─────────────────────────────────────────
        private ProdukController _controller = new ProdukController();

        // ─── Placeholder Image ───────────────────────────────────
        private Image _placeholder;

        // ─── Current filter state ────────────────────────────────
        // "semua", "bunga", or "bibit"
        private string _currentFilter = "semua";

        // ─── Constructor ────────────────────────────────────────
        public HomePageFlorist()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadCards();
        }

        // ─── Load Placeholder ────────────────────────────────────
        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            _placeholder = File.Exists(path) ? Image.FromFile(path) : null;
        }

        // ─── Load & Render Cards ─────────────────────────────────
        private void LoadCards()
        {
            // get data based on current filter
            List<Produk> list;

            switch (_currentFilter)
            {
                case "bunga":
                    list = new List<Produk>(_controller.AmbilSemuaBunga());
                    break;
                case "bibit":
                    list = new List<Produk>(_controller.AmbilSemuaBibit());
                    break;
                default:
                    list = _controller.AmbilSemuaProduk();
                    break;
            }

            // apply search filter on top
            string keyword = tbSearch.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                list = list.FindAll(p =>
                {
                    bool matchNama = p.NamaProduk.ToLower().Contains(keyword);
                    bool matchDetail = p is Bunga b
                        ? (b.JenisBunga.ToLower().Contains(keyword) || b.Warna.ToLower().Contains(keyword))
                        : p is Bibit bi
                            ? bi.JenisTanaman.ToLower().Contains(keyword)
                            : false;
                    return matchNama || matchDetail;
                });
            }

            RenderCards(list);
        }

        // ─── Render Cards into FlowLayoutPanel ───────────────────
        private void RenderCards(List<Produk> list)
        {
            flowLayoutPanelCard.Controls.Clear(); // remove old cards

            if (list.Count == 0)
            {
                // show empty message
                var lblEmpty = new Label
                {
                    Text = "Tidak ada produk ditemukan.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanelCard.Controls.Add(lblEmpty);
                return;
            }

            foreach (var produk in list)
            {
                var card = new ProdukCard();
                card.SetProdukInfo(produk, _placeholder);

                // listen to card button events
                card.UbahClicked += (s, e) => BtnUbah_Click(card.IdProduk);
                card.HapusClicked += (s, e) => BtnHapus_Click(card.IdProduk, produk.NamaProduk);

                flowLayoutPanelCard.Controls.Add(card);

                //var card = BuildCard(produk);
                //flowLayoutPanelCard.Controls.Add(card);


            }


        }

        // ─── Tambah ─────────────────────────────────────────────

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var form = new FormTambahProduk();
            if (form.ShowDialog() == DialogResult.OK)
                LoadCards();
        }

        // ─── Ubah ───────────────────────────────────────────────

        private void BtnUbah_Click(int idProduk)
        {
            var produk = _controller.GetById(idProduk);

            if (produk is Bunga bunga)
            {
                var form = new FormUpdateBunga(bunga);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadCards(); // refresh after update
            }
            else if (produk is Bibit bibit)
            {
                var form = new FormUpdateBibit(bibit);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadCards(); // refresh after update
            }

            LoadCards();
        }



        // ─── Hapus ──────────────────────────────────────────────

        private void BtnHapus_Click(int idProduk, string namaProduk)
        {
            var konfirmasi = MessageBox.Show(
                $"Yakin ingin menghapus \"{namaProduk}\"?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (konfirmasi == DialogResult.Yes)
            {
                bool success = _controller.DeleteProduk(idProduk);
                if (success)
                {
                    MessageBox.Show("Produk berhasil dihapus.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCards();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void btnSemua_Click_1(object sender, EventArgs e)
        {
            _currentFilter = "semua";
            LoadCards();
        }

        private void btnBunga_Click_1(object sender, EventArgs e)
        {
            _currentFilter = "bunga";
            LoadCards();
        }

        private void btnBibit_Click_1(object sender, EventArgs e)
        {
            _currentFilter = "bibit";
            LoadCards();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCards();
            }
        }

        private void semua_Click(object sender, EventArgs e)
        {
            _currentFilter = "semua";
            LoadCards();
        }

        private void bunga_Click(object sender, EventArgs e)
        {
            _currentFilter = "bunga";
            LoadCards();
        }

        private void bibit_Click(object sender, EventArgs e)
        {
            _currentFilter = "bibit";
            LoadCards();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDashboardFlorist().Show();
        }

        private void lblPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPesananFlorist().Show();
        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLaporanFlorist().Show();
        }
    }
}


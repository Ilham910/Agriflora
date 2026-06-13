using Agriflora.Controllers;
using Agriflora.Helpers;
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
    public partial class HomePageCustomer : Form
    {
        // ─── Controller ─────────────────────────────────────────
        private ProdukController _controller = new ProdukController();
        private KeranjangController _keranjangController;

        // ─── Placeholder Image ───────────────────────────────────
        private Image _placeholder;

        // ─── Current filter state ────────────────────────────────
        private string _currentFilter = "semua";

        public HomePageCustomer()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadCards();
            LoadUserInfo();
            _keranjangController = KeranjangHelper.Keranjang;

            this.MouseClick += HomePageCustomer_MouseClick;
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
            // ambil data produk sesuai filter
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

        // ─── Render Cards into FlowLayoutPanel ───────────────────
        private void RenderCards(List<Produk> list)
        {
            flowLayoutPanel1.Controls.Clear(); // hapus card lama

            if (list.Count == 0)
            {

                var lblEmpty = new Label
                {
                    Text = "Tidak ada produk ditemukan.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowLayoutPanel1.Controls.Add(lblEmpty);
                return;
            }

            foreach (var produk in list)
            {
                var card = new CustomerProdukCard();
                card.SetProdukInfo(produk, _placeholder);

                card.MasukClicked += (s, e) => BtnMasuk_Click(produk);
                card.DetailBungaClicked += (s, e) => BtnDetailBunga_Click(produk);

                flowLayoutPanel1.Controls.Add(card);

            }

        }

        private void BtnDetailBunga_Click(Produk produk)
        {
            var form = new FormRincianProduk(produk);
            form.ShowDialog();
        }

        private void BtnMasuk_Click(Produk produk)
        {
            _keranjangController.AddToCart(produk, 1);
            MessageBox.Show($"{produk.NamaProduk} ditambahkan ke keranjang!",
            "Keranjang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomePageCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            _currentFilter = "semua";
            LoadCards();
        }

        private void btnBunga_Click(object sender, EventArgs e)
        {
            _currentFilter = "bunga";
            LoadCards();
        }

        private void btnBibit_Click(object sender, EventArgs e)
        {
            _currentFilter = "bibit";
            LoadCards();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCards();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKeranjang().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormStatusPesanan().Show();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormEditProfilCust(AppSession.CurrentUser).Show();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRiwayatPesanan().Show();
        }
    }
}

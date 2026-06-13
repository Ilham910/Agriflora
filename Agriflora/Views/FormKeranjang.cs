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
    public partial class FormKeranjang : Form
    {
        // ─── Controller ─────────────────────────────────────────
        private KeranjangController _controller = KeranjangHelper.Keranjang;

        // ─── Placeholder ─────────────────────────────────────────
        private Image _placeholder;

        public FormKeranjang()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadKeranjang();

            this.MouseClick += FormKeranjang_MouseClick;
        }

        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            _placeholder = File.Exists(path) ? Image.FromFile(path) : null;
        }

        // ─── Load Keranjang ──────────────────────────────────────
        private void LoadKeranjang()
        {
            flowLayoutPanelKeranjang.Controls.Clear();

            if (_controller.Items.Count == 0)
            {
                flowLayoutPanelKeranjang.Controls.Add(new Label
                {
                    Text = "Keranjang masih kosong.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                });

                lblTotalHarga.Text = "Total: Rp 0";
                return;
            }

            foreach (var item in _controller.Items)
            {
                var card = new ItemKeranjangCard();
                card.SetData(item, _controller, _placeholder);

                // ketika item dihapus → reload semua card
                card.OnHapus += (s, e) => LoadKeranjang();

                // ketika quantity berubah → hanya update label total
                card.OnQuantityChanged += (s, e) => UpdateTotal();

                flowLayoutPanelKeranjang.Controls.Add(card);
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            lblTotalHarga.Text = $"Total: {_controller.GetTotal().ToString("C0", new CultureInfo("id-ID"))}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_controller.Items.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new FormCheckout();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _controller.Clear();
                LoadKeranjang();
            }
        }


        private void FormKeranjang_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePageCustomer().Show();
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
    }
}

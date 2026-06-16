using Agriflora.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class FormPesananFlorist : Form
    {
        private PesananController _controller = new PesananController();
        private string _currentFilter = "semua";
        public FormPesananFlorist()
        {
            InitializeComponent();
            LoadPesanan();
        }


        private void LoadPesanan()
        {
            flowLayoutPanel.Controls.Clear();

            var list = _controller.GetAllPesanan();

            if (_currentFilter != "semua")
                list = list.FindAll(p => p.Status.ToString() == _currentFilter);

            if (list.Count == 0)
            {
                flowLayoutPanel.Controls.Add(new Label
                {
                    Text = "Tidak ada pesanan.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                });
                return;
            }

            foreach (var p in list)
            {
                var rincian = _controller.GetRincianByPesanan(p.IdPesanan);
                string produkList = string.Join(", ",
                    rincian.ConvertAll(r => $"{r.NamaProduk} x{r.Quantity}"));
                string customer = GetNamaPengguna(p.IdPengguna);

                var card = new PesananRowCard();
                card.SetData(p, customer, produkList);
                card.Width = flowLayoutPanel.Width - 4;
                flowLayoutPanel.Controls.Add(card);
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

        private void HighlightButton(Button active)
        {
            var all = new[] { btnSemua, btnMenunggu, btnDiproses, btnSiap, btnSelesai };
            foreach (var b in all)
            {
                b.BackColor = SystemColors.Control;
                b.ForeColor = Color.Black;
                b.FlatStyle = FlatStyle.Standard;
            }
            active.BackColor = Color.FromArgb(163, 60, 90);
            active.ForeColor = Color.White;
            active.FlatStyle = FlatStyle.Flat;
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            _currentFilter = "semua";
            HighlightButton(btnSemua);
            LoadPesanan();
        }

        private void btnMenunggu_Click(object sender, EventArgs e)
        {
            _currentFilter = "MenungguPembayaran";
            HighlightButton(btnMenunggu);
            LoadPesanan();
        }

        private void btnDiproses_Click(object sender, EventArgs e)
        {
            _currentFilter = "Diproses";
            HighlightButton(btnDiproses);
            LoadPesanan();
        }

        private void btnSiap_Click(object sender, EventArgs e)
        {
            _currentFilter = "SiapDiambil";
            HighlightButton(btnSiap);
            LoadPesanan();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            _currentFilter = "Selesai";
            HighlightButton(btnSelesai);
            LoadPesanan();
        }

        private void lblPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDashboardFlorist().Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePageFlorist().Show();
        }

        private void lblLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLaporanFlorist().Show();
        }
    }
}

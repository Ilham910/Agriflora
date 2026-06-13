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
    public partial class FormRiwayatPesanan : Form
    {
        private PesananController _controller = new PesananController();
        private Image _placeholder;

        private string _currentFilter = "semua";
        public Status _currentstatus = Status.MenungguPembayaran;

        public FormRiwayatPesanan()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadCard();
        }



        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            _placeholder = File.Exists(path) ? Image.FromFile(path) : null;
        }

        private void LoadCard()
        {
            flowLayoutPanel1.Controls.Clear();


            List<PesananHeader> list;

            // fetch based on current filter
            switch (_currentFilter)
            {
                case "semua":
                    list = _controller.GetPesananByPengguna(AppSession.CurrentUser.IdPengguna);
                    break;
                case "menunggu":
                    list = _controller.GetPesananByStatus(AppSession.CurrentUser.IdPengguna, Status.MenungguPembayaran);
                    break;
                case "diproses":
                    list = _controller.GetPesananByStatus(AppSession.CurrentUser.IdPengguna, Status.Diproses);
                    break;
                case "siapdiambil":
                    list = _controller.GetPesananByStatus(AppSession.CurrentUser.IdPengguna, Status.SiapDiambil);
                    break;
                case "diambil":
                    list = _controller.GetPesananByStatus(AppSession.CurrentUser.IdPengguna, Status.Diambil);
                    break;
                case "selesai":
                    list = _controller.GetPesananByStatus(AppSession.CurrentUser.IdPengguna, Status.Selesai);
                    break;
                default:
                    list = _controller.GetPesananByPengguna(AppSession.CurrentUser.IdPengguna);
                    break;
            }

            if (list.Count == 0)
            {
                flowLayoutPanel1.Controls.Add(new Label
                {
                    Text = "Belum ada riwayat pesanan.",
                    Font = new Font("Segoe UI", 11),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                });
                return;
            }
            else
            {
                foreach (var pesanan in list)
                {
                    var card = new StatusPesananCard();
                    card.SetData(pesanan);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }

            //foreach (var pesanan in list)
            //{
            //    var rincianList = _controller.GetRincianByPesanan(pesanan.IdPesanan);

            //    // BUG 1 FIX: skip pesanan with no rincian instead of crashing
            //    if (rincianList.Count == 0) continue;

            //    var card = new RiwayatPesananCard();
            //    card.setData(pesanan, rincianList[0], _placeholder);
            //    flowLayoutPanel1.Controls.Add(card);
            //}
        }


        private void HighlightActiveButton(Button activeBtn)
        {
            // list all filter buttons
            var buttons = new[]
            {
                btnSemua, btnMenunggu, btnDiproses,
                btnSiap, btnDiambil, btnSelesai
            };

            // reset all to default
            foreach (var btn in buttons)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Standard;
            }

            // highlight the active one
            activeBtn.BackColor = Color.FromArgb(15, 110, 86);
            activeBtn.ForeColor = Color.White;
            activeBtn.FlatStyle = FlatStyle.Flat;
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            _currentFilter = "semua";
            HighlightActiveButton(btnSemua);
            LoadCard();
        }

        private void btnMenunggu_Click(object sender, EventArgs e)
        {
            _currentFilter = "menunggu";
            HighlightActiveButton(btnMenunggu);
            LoadCard();
        }

        private void btnDiproses_Click(object sender, EventArgs e)
        {
            _currentFilter = "diproses";
            HighlightActiveButton(btnDiproses);
            LoadCard();
        }

        private void btnSiap_Click(object sender, EventArgs e)
        {
            _currentFilter = "siapdiambil";
            HighlightActiveButton(btnSiap);
            LoadCard();
        }

        private void btnDiambil_Click(object sender, EventArgs e)
        {
            _currentFilter = "diambil";
            HighlightActiveButton(btnDiambil);
            LoadCard();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            _currentFilter = "selesai";
            HighlightActiveButton(btnSelesai);
            LoadCard();
        }

        private void lblKembali_Click(object sender, EventArgs e)
        {
            new HomePageCustomer().Show();
            this.Close();
        }
    }
}

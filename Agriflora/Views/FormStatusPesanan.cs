using Agriflora.Controllers;
using Agriflora.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agriflora.Views
{
    public partial class FormStatusPesanan : Form
    {
        private PesananController _controller = new PesananController();
        private Image _placeholder;

        public FormStatusPesanan()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadPesanan();
        }

        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            _placeholder = File.Exists(path) ? Image.FromFile(path) : null;
        }

        private void LoadPesanan()
        {
            flowPesanan.Controls.Clear();

            var list = _controller.GetPesananByPengguna(AppSession.CurrentUser.IdPengguna);


            if (list.Count == 0)
            {
                flowPesanan.Controls.Add(new Label
                {
                    Text = "Belum ada pesanan.",
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
                    flowPesanan.Controls.Add(card);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            new HomePageCustomer().Show();
            this.Close();
        }
    }
}

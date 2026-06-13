using Agriflora.Controllers;
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
    public partial class StatusPesananCard : UserControl
    {
        private PesananController _controller = new PesananController();
        private Image _placeholder;
        private PesananHeader _pesanan; // store reference for the Bayar button


        public StatusPesananCard()
        {
            InitializeComponent();
        }


        public void SetData(PesananHeader pesanan)
        {
            _pesanan = pesanan; // save for use in btnBayar_Click

            var rincianList = _controller.GetRincianByPesanan(pesanan.IdPesanan);
            int currentStep = (int)pesanan.Status;

            lblIdPesanan.Text = $"ID Pesanan: {pesanan.IdPesanan}";
            lblTanggal.Text = $"{pesanan.TanggalPesanan:dd MMM yyyy} · {rincianList.Count} produk";
            lblStatus.Text = pesanan.Status.ToString();
            lblTotal.Text = $"Total: Rp {pesanan.TotalHarga:N0}";

            // show Bayar button only for unpaid QRIS orders
            btnBayar.Visible = (pesanan.Status == Status.MenungguPembayaran);

            LoadItems(rincianList);

        }

        private void LoadItems(List<RincianPesanan> rincianList)
        {
            flowItemPesanan.Controls.Clear();

            foreach (var item in rincianList)
            {
                var row = new ItemPesananCard();
                row.SetData(item, _placeholder);
                flowItemPesanan.Controls.Add(row);
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            var formQris = new FormQris(
                (decimal)_pesanan.TotalHarga,
                _pesanan.IdPesanan,
                _controller
            );

            var result = formQris.ShowDialog();

            if (result == DialogResult.OK)
            {
                // payment done — update label and hide button immediately
                lblStatus.Text = Status.Diproses.ToString();
                btnBayar.Visible = false;

                MessageBox.Show("Pembayaran berhasil! Pesanan sedang diproses.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

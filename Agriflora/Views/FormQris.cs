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
using static Agriflora.Models.Pembayaran;

namespace Agriflora.Views
{
    public partial class FormQris : Form
    {

        private decimal _total;
        private PesananController _controller;
        private int _idPesanan;
        private DateTime _deadline;

        // ── ABSTRACT: pakai PembayaranQris (subclass konkret) ────
        //    bukan Pembayaran langsung, karena Pembayaran sudah abstract
        private PembayaranQris _pembayaran = new PembayaranQris();

        public FormQris(decimal total, int idPesanan, PesananController controller)
        {
            _total = total;
            _idPesanan = idPesanan;
            _controller = controller;
            InitializeComponent();
            LoadDeadline();

            // ── ABSTRACT: GetInstruksi() dari PembayaranQris ─────
            //    ditampilkan langsung ke user di form
            lblInstruksi.Text = _pembayaran.GetInstruksi();
        }

        private void LoadDeadline()
        {
            // fetch the saved deadline from DB
            var saved = _controller.GetDeadlineBayar(_idPesanan);

            // if for some reason it's null, fall back to 24h from now
            _deadline = saved.HasValue ? saved.Value : DateTime.Now.AddHours(24);

            // display as fixed date-time, no ticking
            lblDeadline.Text = _deadline.ToString("dd MMM yyyy, HH:mm");
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxGambar.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxGambar.SizeMode = PictureBoxSizeMode.Zoom;

                    // ── tandai sudah upload bukti di objek pembayaran ─
                    _pembayaran.SudahUploadBukti = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > _deadline)
            {
                MessageBox.Show(
                    "Waktu pembayaran telah habis. Pesanan ini tidak dapat dibayar lagi.",
                    "Waktu Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // ── ABSTRACT: Validasi() → di PembayaranQris cek SudahUploadBukti
            //    kalau pakai PembayaranCash, Validasi() selalu return true
            if (!_pembayaran.Validasi())
            {
                MessageBox.Show(
                    "Tolong unggah bukti pembayaran terlebih dahulu.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _controller.KonfirmasiPembayaran(_idPesanan);

            MessageBox.Show(
                $"Terima kasih! Pesanan Anda sedang diproses.\n" +
                // ── ABSTRACT: GetStatusDisplay() dari base class Pembayaran ─
                $"{_pembayaran.GetStatusDisplay()}",
                "Pesanan Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblDeadline_Click(object sender, EventArgs e)
        {

        }
    }
}

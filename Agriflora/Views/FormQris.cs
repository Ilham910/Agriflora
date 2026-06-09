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
        private TimeSpan timeRemaining = TimeSpan.FromHours(24);

        private decimal _total;
        private PesananController _controller;
        private int _idPesanan;

        // ── ABSTRACT: pakai PembayaranQris (subclass konkret) ────
        //    bukan Pembayaran langsung, karena Pembayaran sudah abstract
        private PembayaranQris _pembayaran = new PembayaranQris();

        public FormQris(decimal total, int idPesanan, PesananController controller)
        {
            _total = total;
            _idPesanan = idPesanan;
            _controller = controller;
            InitializeComponent();
            TimeLoad();

            // ── ABSTRACT: GetInstruksi() dari PembayaranQris ─────
            //    ditampilkan langsung ke user di form
            lblInstruksi.Text = _pembayaran.GetInstruksi();
        }


        private void TimeLoad()
        {
            // 1. Display the initial 24:00:00 time immediately
            DisplayTime();

            // 2. Configure the timer interval to 1 second (1000 milliseconds)
            countdownTimer.Interval = 1000;

            // 3. Attach the Tick event handler
            countdownTimer.Tick += CountdownTimer_Tick;

            // 4. Start the timer automatically
            countdownTimer.Start();
        }

        // This method runs every 1 second
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining.TotalSeconds > 0)
            {
                // Subtract 1 second from the remaining time
                timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1));

                // Update the label display
                DisplayTime();
            }
            else
            {
                // Stop the timer when it reaches 00:00:00
                countdownTimer.Stop();
                MessageBox.Show("Time is up!", "Timer Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Helper method to format and display the time
        private void DisplayTime()
        {
            // Formats the time as HH:mm:ss (e.g., 23:59:59)
            lblCountdown.Text = timeRemaining.ToString(@"hh\:mm\:ss");
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
    }
}

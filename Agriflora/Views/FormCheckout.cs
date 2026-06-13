using Agriflora.Controllers;
using Agriflora.Helpers;
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

    public partial class FormCheckout : Form
    {
        private KeranjangController _keranjang = KeranjangHelper.Keranjang;
        private PesananController _pesanan = new PesananController();
        private Image _placeholder;
        private int _idPesanan; // untuk di pass ke form QRIS

        // ── ABSTRACT: tidak bisa new Pembayaran() langsung.
        //    Diisi dengan PembayaranQris atau PembayaranCash
        //    saat user memilih metode pembayaran.
        private Pembayaran _bayar = null;


        // ── Voucher state ────────────────────────────────────────
        // null  = belum pakai voucher
        // jenis bisa "persen" atau "potongan"
        private string _voucherJenis = null;
        private double _diskonPersen = 0;
        private decimal _potonganHarga = 0;

        // Daftar voucher yang valid
        private static readonly Dictionary<string, (string jenis, double nilai)> _daftarVoucher =
            new Dictionary<string, (string, double)>(StringComparer.OrdinalIgnoreCase)
            {
                { "AGRI10",    ("persen",   10) },   // diskon 10%
                { "AGRI20",    ("persen",   20) },   // diskon 20%
                { "HEMAT5K",   ("potongan", 5000) },  // potongan Rp 5.000
                { "HEMAT15K",  ("potongan", 15000) }, // potongan Rp 15.000
            };



        public FormCheckout()
        {
            InitializeComponent();
            LoadPlaceholder();
            LoadOrderSummary();
        }

        private void LoadPlaceholder()
        {
            string path = Path.Combine(Application.StartupPath, "no-image.jpg");
            _placeholder = File.Exists(path) ? Image.FromFile(path) : null;
        }

        private void LoadOrderSummary()
        {
            flowLayoutPanelCheckout.Controls.Clear();

            foreach (var item in _keranjang.Items)
            {
                var card = new ItemCheckoutCard();
                card.SetData(item, _keranjang, _placeholder);
                // jika quantity berubah → update total
                card.OnQuantityChanged += (s, e) => UpdateTotal();

                // jika item dihapus → reload semua card
                card.OnHapus += (s, e) => LoadOrderSummary();
                flowLayoutPanelCheckout.Controls.Add(card);
            }

            // total
            lblTotalHarga.Text = $"Total: {_keranjang.GetTotal().ToString("C0", new CultureInfo("id-ID"))}";

        }

        private void UpdateTotal()
        {
            var items = _keranjang.Items;

            if (_voucherJenis == "persen")
            {
                // ── OVERLOADING: SubtotalDenganDiskon(double) dipanggil per item,
                //    lalu dijumlahkan untuk total akhir setelah diskon
                decimal totalSetelahDiskon = 0;
                foreach (var item in items)
                    totalSetelahDiskon += item.SubtotalDenganDiskon(_diskonPersen);

                decimal potongan = _keranjang.GetTotal() - totalSetelahDiskon;

                lblTotalHarga.Text = $"Total: {totalSetelahDiskon.ToString("C0", new CultureInfo("id-ID"))}";
                lblDiskon.Text = $"Diskon ({_diskonPersen}%): -Rp {potongan:N0}";
                lblDiskon.Visible = true;
            }
            else if (_voucherJenis == "potongan")
            {
                // ── OVERLOADING: SubtotalDenganPotongan(decimal) — potongan dibagi
                //    rata ke semua item berdasarkan proporsi subtotal-nya
                decimal totalAsli = _keranjang.GetTotal();
                decimal totalAkhir = Math.Max(0, totalAsli - _potonganHarga);

                lblTotalHarga.Text = $"Total: {totalAkhir.ToString("C0", new CultureInfo("id-ID"))}";
                lblDiskon.Text = $"Potongan Voucher: -Rp {_potonganHarga:N0}";
                lblDiskon.Visible = true;
            }
            else
            {
                // tidak ada voucher — pakai total biasa
                lblTotalHarga.Text = $"Total: {_keranjang.GetTotal().ToString("C0", new CultureInfo("id-ID"))}";
                lblDiskon.Visible = false;
            }
        }

        private void lblTotalHarga_Click(object sender, EventArgs e)
        {

        }

        private void radioQris_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (_keranjang.Items.Count == 0)
            {
                MessageBox.Show("Keranjang kosong. Silakan tambahkan produk terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!radioQris.Checked && !radioCash.Checked)
            {
                MessageBox.Show("Silakan pilih metode pembayaran.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rincianList = new List<RincianPesanan>();
            foreach (var item in _keranjang.Items)
            {
                rincianList.Add(new RincianPesanan
                {
                    IdProduk = item.Produk.IdProduk,
                    Quantity = item.Quantity,
                    Harga = item.Produk.Harga,
                    // ── OVERLOADING: subtotal per item sudah include diskon/potongan
                    Subtotal = _voucherJenis == "persen"
                        ? item.SubtotalDenganDiskon(_diskonPersen)
                        : item.Subtotal
                });
            }

            // total akhir setelah voucher
            decimal totalAkhir = GetTotalAkhir();

            // ── ABSTRACT: buat subclass konkret sesuai pilihan user ──
            //    Polymorphism: _bayar bertipe Pembayaran (abstract),
            //    tapi isinya PembayaranQris atau PembayaranCash
            if (radioQris.Checked)
            {
                _bayar = new PembayaranQris();
            }
            else
            {
                _bayar = new PembayaranCash();
            }


            int idPesanan = _pesanan.Checkout(rincianList, _keranjang.GetTotal(), "QRIS");

            if (idPesanan > 0 && _bayar.MetodeBayar == "QRIS")

            {
                MessageBox.Show(
                    $"{_bayar.GetInstruksi()}",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // buka form QRIS untuk proses pembayaran
                var formQris = new FormQris(totalAkhir, idPesanan, _pesanan);
                var result = formQris.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // user completed payment in FormQris
                    _keranjang.Clear();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (idPesanan > 0)
            {
                _pesanan.KonfirmasiPembayaran(idPesanan);

                MessageBox.Show(
                    $"{_bayar.GetInstruksi()}",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _keranjang.Clear();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal melakukan checkout. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPakaiVoucher_Click(object sender, EventArgs e)
        {
            string kode = tbVoucher.Text.Trim();

            if (string.IsNullOrWhiteSpace(kode))
            {
                MessageBox.Show("Masukkan kode voucher terlebih dahulu.", "Voucher",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_daftarVoucher.TryGetValue(kode, out var voucher))
            {
                _voucherJenis = voucher.jenis;

                if (voucher.jenis == "persen")
                {
                    _diskonPersen = voucher.nilai;
                    _potonganHarga = 0;
                    lblVoucherStatus.Text = $"✓ Voucher {kode} — diskon {_diskonPersen}% berhasil dipakai!";
                    lblVoucherStatus.ForeColor = Color.Green;
                }
                else
                {
                    _potonganHarga = (decimal)voucher.nilai;
                    _diskonPersen = 0;
                    lblVoucherStatus.Text = $"✓ Voucher {kode} — potongan Rp {_potonganHarga:N0} berhasil dipakai!";
                    lblVoucherStatus.ForeColor = Color.Green;
                }

                UpdateTotal();
            }
            else
            {
                // reset voucher jika kode salah
                _voucherJenis = null;
                _diskonPersen = 0;
                _potonganHarga = 0;

                lblVoucherStatus.Text = "✗ Kode voucher tidak valid.";
                lblVoucherStatus.ForeColor = Color.Red;
                lblDiskon.Visible = false;

                UpdateTotal();
            }

            lblVoucherStatus.Visible = true;
        }

        private decimal GetTotalAkhir()
        {
            if (_voucherJenis == "persen")
            {
                decimal total = 0;
                foreach (var item in _keranjang.Items)
                    total += item.SubtotalDenganDiskon(_diskonPersen);
                return total;
            }
            else if (_voucherJenis == "potongan")
            {
                return Math.Max(0, _keranjang.GetTotal() - _potonganHarga);
            }
            return _keranjang.GetTotal();
        }
    }
}

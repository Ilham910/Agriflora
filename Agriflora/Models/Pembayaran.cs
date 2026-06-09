using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Models
{
    // ── ABSTRACT: Pembayaran tidak bisa diinstansiasi langsung.
    //    Setiap transaksi PASTI pakai QRIS atau Cash — keduanya
    //    punya cara validasi dan instruksi yang berbeda.
    public abstract class Pembayaran
    {
        public int IdPembayaran { get; set; }
        public int IdPesanan { get; set; }
        public string MetodeBayar { get; set; }
        public string StatusBayar { get; set; }
        public DateTime TanggalBayar { get; set; }


        // ── Abstract method: wajib diimplementasikan subclass ────
        // Validasi sebelum konfirmasi pembayaran (misal: cek bukti foto dll)
        public abstract bool Validasi();

        // Instruksi pembayaran yang ditampilkan ke user
        public abstract string GetInstruksi();

        // Label metode untuk ditampilkan di struk/UI
        public abstract string GetLabelMetode();

        // ── Non-abstract: shared ─────────────────────────────────
        public string GetStatusDisplay()
        {
            return StatusBayar == "Lunas"
                ? $"✓ Lunas via {GetLabelMetode()}"
                : $"⏳ Menunggu pembayaran via {GetLabelMetode()}";
        }



        // ── QRIS: user upload bukti transfer, butuh verifikasi foto ─
        public class PembayaranQris : Pembayaran
        {
            // apakah user sudah upload bukti bayar
            public bool SudahUploadBukti { get; set; } = false;

            public PembayaranQris()
            {
                MetodeBayar = "QRIS";
            }

            public override bool Validasi()
            {
                // QRIS butuh bukti foto sebelum bisa dikonfirmasi
                return SudahUploadBukti;
            }

            public override string GetInstruksi()
                => "Scan QR Code, lalu upload bukti pembayaran untuk konfirmasi.";

            public override string GetLabelMetode() => "QRIS";
        }

        // ── Cash: langsung lunas, tidak butuh upload bukti ──────────
        public class PembayaranCash : Pembayaran
        {
            public PembayaranCash()
            {
                MetodeBayar = "Cash";
            }

            public override bool Validasi()
            {
                // Cash selalu valid — langsung dikonfirmasi
                return true;
            }

            public override string GetInstruksi()
                => "Bayar langsung ke kasir. Pesanan akan langsung diproses.";

            public override string GetLabelMetode() => "Cash";
        }
    }
}

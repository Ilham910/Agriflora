using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Agriflora.Models
{
    public class Produk
    {
        private decimal _harga;
        private int _stok;

        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public byte[] GambarProduk { get; set; }
        public int? IdBunga { get; set; }
        public int? IdBibit { get; set; }

        public decimal Harga
        {
            get => _harga;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga tidak boleh negatif.");
                _harga = value;
            }
        }

        // ─── OVERRIDING: virtual method untuk di-override child class ─
        // Polymorphism: setiap produk bisa kembalikan deskripsi singkatnya sendiri
        public virtual string GetDeskripsiSingkat()
        {
            return $"{NamaProduk} - Rp {Harga:N0} (Stok: {Stok})";
        }

        // virtual method untuk label jenis produk
        public virtual string GetJenisProduk()
        {
            return "Produk";
        }

        // Enkapsulasi: Stok tidak boleh negatif
        public int Stok
        {
            get => _stok;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok tidak boleh negatif.");
                _stok = value;
            }
        }

        // ─── OVERLOADING: HitungTotal dengan berbagai parameter ───────
        // Overloading 1: hitung total dari quantity
        public decimal HitungTotal(int quantity)
        {
            return Harga * quantity;
        }

        // Overloading 2: hitung total dengan diskon persen (0-100)
        public decimal HitungTotal(int quantity, double diskonPersen)
        {
            decimal total = Harga * quantity;
            decimal diskon = total * (decimal)(diskonPersen / 100.0);
            return total - diskon;
        }

        // Overloading 3: hitung total dengan potongan harga langsung
        public decimal HitungTotal(int quantity, decimal potonganHarga)
        {
            decimal total = Harga * quantity;
            return Math.Max(0, total - potonganHarga);
        }
    }

    public class Bunga : Produk
    {
        public int IdBunga { get; set; }
        public string JenisBunga { get; set; }
        public string Warna { get; set; }
        public string DeskripsiBunga { get; set; }

        // ─── OVERRIDING: Bunga punya deskripsi singkat sendiri ────────
        public override string GetDeskripsiSingkat()
        {
            return $@"{NamaProduk} ({Warna}) 
Rp {Harga:N0} 
Stok: {Stok}";
        }

        public override string GetJenisProduk()
        {
            return "Bunga";
        }
    }

    public class Bibit : Produk
    {
        public int IdBibit { get; set; }
        public string JenisTanaman { get; set; }
        public string DeskripsiBibit { get; set; }

        // ─── OVERRIDING: Bibit punya deskripsi singkat sendiri ────────
        public override string GetDeskripsiSingkat()
        {
            return $@"{NamaProduk} 
Tanaman: {JenisTanaman}
Rp {Harga:N0} 
Stok: {Stok}";
        }

        public override string GetJenisProduk()
        {
            return "Bibit";
        }
    }
}

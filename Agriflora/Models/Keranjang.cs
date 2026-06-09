using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Models
{
    public class Keranjang
    {
        public Produk Produk { get; set; }
        public int Quantity { get; set; }


        // Subtotal tanpa diskon — pakai overloading HitungTotal(int)
        public decimal Subtotal => Produk.HitungTotal(Quantity);

        // Subtotal dengan diskon persen — pakai overloading HitungTotal(int, double)
        public decimal SubtotalDenganDiskon(double diskonPersen)
        {
            return Produk.HitungTotal(Quantity, diskonPersen);
        }

        // Subtotal dengan potongan langsung — pakai overloading HitungTotal(int, decimal)
        public decimal SubtotalDenganPotongan(decimal potonganHarga)
        {
            return Produk.HitungTotal(Quantity, potonganHarga);
        }

        // Polymorphism: pakai GetJenisProduk() dari masing-masing child class
        public string GetInfoKeranjang()
        {
            return $"[{Produk.GetJenisProduk()}] {Produk.GetDeskripsiSingkat()}";
        }
    }
}

using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Controllers
{
    public class KeranjangController
    {
        private static List<Keranjang> _items = new List<Keranjang>();

        public IReadOnlyList<Keranjang> Items => _items;

        public void AddToCart(Produk produk, int qty)
        {
            var existing = _items.FirstOrDefault(x => x.Produk.IdProduk == produk.IdProduk);

            if (existing != null)
                existing.Quantity += qty;  // jika produk sudah ada di keranjang, tambahkan quantity
            else
                _items.Add(new Keranjang { Produk = produk, Quantity = qty });
        }

        public void HapusItem(int idProduk)
        {
            _items.RemoveAll(x => x.Produk.IdProduk == idProduk);
        }

        public void UpdateQuantity(int idProduk, int newQty)
        {
            var item = _items.FirstOrDefault(x => x.Produk.IdProduk == idProduk);
            if (item != null)
            {
                if (newQty <= 0)
                    HapusItem(idProduk); // jika qty 0 atau negatif, hapus item dari keranjang
                else
                    item.Quantity = newQty;
            }
        }

        public int GetTotalItems()
        {
            return _items.Sum(x => x.Quantity);
        }

        public decimal GetTotal()
        {
            return _items.Sum(x => x.Subtotal);
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}

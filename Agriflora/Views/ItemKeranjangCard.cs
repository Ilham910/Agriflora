using Agriflora.Controllers;
using Agriflora.Interfaces;
using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Agriflora.Views
{
    public partial class ItemKeranjangCard : UserControl
    {
        // ─── Events ─────────────────────────────────────────────
        public event EventHandler OnHapus;
        public event EventHandler OnQuantityChanged;

        // ─── Fields ─────────────────────────────────────────────
        private Keranjang _item;
        private KeranjangController _controller;

        public ItemKeranjangCard()
        {
            InitializeComponent();
        }

        public void SetData(Keranjang item, KeranjangController controller, Image placeholder)
        {
            _item = item;
            _controller = controller;

            // image
            if (item.Produk.GambarProduk != null)
            {
                try
                {
                    using var ms = new MemoryStream(item.Produk.GambarProduk);
                    pictureBoxGambar.Image = Image.FromStream(ms);
                }
                catch { pictureBoxGambar.Image = placeholder; }
            }
            else
            {
                pictureBoxGambar.Image = placeholder;
            }

            // ── OVERRIDING: GetJenisProduk() dipanggil via Produk (polymorphism)
            //    "Bunga" atau "Bibit" sesuai tipe sebenarnya
            lblNama.Text = $"[{item.Produk.GetJenisProduk()}] {item.Produk.NamaProduk}";
            lblHarga.Text = $"Rp {item.Produk.Harga:N0}";

            // ── OVERLOADING + POLYMORPHISM: GetInfoKeranjang() pakai
            //    HitungTotal(int) dan GetDeskripsiSingkat() dari subclass
            toolTip1.SetToolTip(this, item.GetInfoKeranjang());

            // quantity and subtotal
            RefreshQtyAndSubtotal();
        }

        private void RefreshQtyAndSubtotal()
        {
            lblKuantitas.Text = _item.Quantity.ToString();

            // ── OVERLOADING: Subtotal pakai HitungTotal(int quantity)
            lblSubtotal.Text = $" Rp.{_item.Subtotal:N0}";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            _controller.HapusItem(_item.Produk.IdProduk);
            OnHapus?.Invoke(this, e); // tell parent to remove this card
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _controller.UpdateQuantity(_item.Produk.IdProduk, _item.Quantity + 1);
            RefreshQtyAndSubtotal();
            OnQuantityChanged?.Invoke(this, e); // tell parent to update total
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (_item.Quantity <= 1)
            {
                // quantity will hit 0 → remove immediately
                _controller.HapusItem(_item.Produk.IdProduk);
                OnHapus?.Invoke(this, e);
            }
            else
            {
                _controller.UpdateQuantity(_item.Produk.IdProduk, _item.Quantity - 1);
                RefreshQtyAndSubtotal();
                OnQuantityChanged?.Invoke(this, e);
            }
        }
    }
}

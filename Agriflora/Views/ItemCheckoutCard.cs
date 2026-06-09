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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Agriflora.Views
{
    public partial class ItemCheckoutCard : UserControl
    {
        // ─── Events ─────────────────────────────────────────────
        public event EventHandler OnHapus;
        public event EventHandler OnQuantityChanged;

        // ─── Fields ─────────────────────────────────────────────
        private Keranjang _item;
        private KeranjangController _controller;

        public ItemCheckoutCard()
        {
            InitializeComponent();
        }

        public void SetData(Keranjang item, KeranjangController controller, Image placeholder)
        {
            _item = item;
            _controller = controller;

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

            lblNama.Text = item.Produk.NamaProduk;
            lblHarga.Text = item.Produk.Harga.ToString("C0", new CultureInfo("id-ID"));
            lblKuantitas.Text = item.Quantity.ToString();

            RefreshQty();

        }

        private void RefreshQty()
        {
            lblKuantitas.Text = _item.Quantity.ToString();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (_item.Quantity >= _item.Produk.Stok)
            {
                MessageBox.Show($"Stok hanya tersedia {_item.Produk.Stok}.", "Stok Habis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _controller.UpdateQuantity(_item.Produk.IdProduk, _item.Quantity + 1);
            RefreshQty();
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
                RefreshQty();
                OnQuantityChanged?.Invoke(this, e);
            }
        }
    }
}

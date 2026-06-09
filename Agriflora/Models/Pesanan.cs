using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Models
{
    public abstract class BaseModel
    {
        public abstract int Id { get; set; }
        public abstract string GetTableName();
    }
    public enum Status
    {
        MenungguPembayaran, 
        Diproses, 
        SiapDiambil, 
        Diambil, 
        Selesai,
    }
    public class PesananHeader : BaseModel
    {
        private int _id;
        public override int Id
        {
            get => _id;
            set => _id = value;
        }
        public int IdPesanan
        {
            get => Id;
            set => Id = value;
        }
        public int IdPengguna { get; set; }
        public DateTime TanggalPesanan { get; set; }
        public double TotalHarga { get; set; }
        public Status Status { get; set; }

        public override string GetTableName()
        {
            return "Pesanan";
        }

        public string GetSelectQuery()
        {
            return $"SELECT * FROM {GetTableName()} WHERE id_pengguna = @id ORDER BY tanggal_pesanan DESC";
        }

        public string GetUpdateStatusQuery()
        {
            return $"UPDATE {GetTableName()} SET status_pesanan = @status WHERE id_pesanan = @id";
        }

    }

    public class RincianPesanan
    {
        public int IdRincian { get; set; }
        public int IdPesanan { get; set; }
        public int IdProduk { get; set; }
        public int Quantity { get; set; }
        public decimal Harga { get; set; }
        public decimal Subtotal { get; set; }

        public string NamaProduk { get; set; }
        public byte[] Gambar { get; set; }

    }

    public class Pesanan
    {
        public int IdPesanan { get; set; }
        public int IdPengguna { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; }
        public decimal TotalBelanja { get; set; }
    }

}

using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Interfaces
{
    public interface IProduk
    {
        bool TambahBunga(Bunga bunga);
        bool TambahBibit(Bibit bibit);
        bool UpdateBunga(Bunga bunga);
        bool UpdateBibit(Bibit bibit);
        bool DeleteProduk(int id);

        List<Produk> AmbilSemuaProduk();

        Produk GetById(int id);
    }
}

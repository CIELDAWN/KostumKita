using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    public class KostumTradisional : Kostum
    {
            public string DaerahAsal { get; set; }

            public KostumTradisional(string nama, int stok, decimal harga, string ukuran, Image gambar, string daerahAsal)
                : base(nama, stok, harga, ukuran, gambar)
            {
                DaerahAsal = daerahAsal;
            }

    }
}

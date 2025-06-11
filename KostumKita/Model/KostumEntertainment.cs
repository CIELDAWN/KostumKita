using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    public class KostumEntertainment : Kostum
    {
            public decimal HargaBeli { get; set; }

            public KostumEntertainment(string nama, int stok, decimal harga, string ukuran, Image gambar,decimal hargaBeli)
                : base(nama, stok, harga, ukuran, gambar)
            {
                HargaBeli = hargaBeli;
            }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    public class Kostum
    {
        public string Nama { get; set; }
        public int Stok { get; set; }
        public decimal Harga { get; set; }
        public string Ukuran { get; set; }
        public Image Gambar { get; set; }

        public Kostum(string nama, int stok, decimal harga, string ukuran, Image gambar)
        {
            Nama = nama;
            Stok = stok;
            Harga = harga;
            Ukuran = ukuran;
            Gambar = gambar;
        }
    }
}

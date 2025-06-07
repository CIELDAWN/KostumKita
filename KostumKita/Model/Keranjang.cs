using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    public static class Keranjang
    {
        public static List<KostumTradisional> DaftarKeranjang = new List<KostumTradisional>();

        public static void Tambah(KostumTradisional kostum)
        {
            DaftarKeranjang.Add(kostum);
        }
    }
}

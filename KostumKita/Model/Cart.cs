using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    public class Cart
    {
        public int IdCart { get; set; }
        public string JenisKostum { get; set; }
        public int JumlahItem { get; set; }
        public int IdKostumEntert { get; set; }
        public string JenisTransaksi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    class TransaksiAdmin
    {
        public  int id_transaksi { get; set; }
        public int id_cart { get; set; }
        public string jumlah_kostum_sewa { get; set; }
        public string jumlah_kostum_beli { get; set; }
        public decimal total_biaya { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public string metode_pembayaran { get; set;}
        public int id_carts { get; set; }
        public int user_id { get; set; }
    }
}

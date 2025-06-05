using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace KostumKita.Model
{
    internal class KeranjangContext
    {
        private readonly NpgsqlConnection conn;

        public KeranjangContext()
        {
            conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=stanley;Database=KostumKita");
        }

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void TambahKeranjang(string namaKostum, string jenisTransaksi)
        {
            conn.Open();
            string query = "INSERT INTO keranjang (nama_kostum, jenis_transaksi) VALUES (@namaKostum, @jenisTransaksi)";
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("namaKostum", namaKostum);
                cmd.Parameters.AddWithValue("jenisTransaksi", jenisTransaksi);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}

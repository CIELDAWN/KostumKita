using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using System.Windows.Forms;


internal class KeranjangContext
{
    private readonly NpgsqlConnection conn;

    public KeranjangContext()
    {
        conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Sinta2074;Database=KostumKita");
    }

    public void OpenConnection()
    {
        if (conn.State == System.Data.ConnectionState.Closed)
        {
            conn.Open();
        }
    }

    public void TambahKeranjangDariNama(string namaKostum, string jenisKostum)
    {
        try
        {
            OpenConnection();

            // Cari id_kostum_tradisional dari nama kostum
            string cariIdQuery = "SELECT id_kostum_tradisional FROM traditional_costumes WHERE nama_kostum = @nama";
            int id = -1;

            using (var cmd = new NpgsqlCommand(cariIdQuery, conn))
            {
                cmd.Parameters.AddWithValue("nama", namaKostum);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("Kostum tidak ditemukan di database.");
                }
            }

            // Masukkan ke tabel carts
            string insertQuery = "INSERT INTO carts (id_kostum_tradisional, jenis_kostum, jumlah_item) VALUES (@id, @jenis, @jumlah)";
            using (var cmd = new NpgsqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("jenis", jenisKostum);
                cmd.Parameters.AddWithValue("jumlah", 1);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Gagal menambahkan ke keranjang: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}

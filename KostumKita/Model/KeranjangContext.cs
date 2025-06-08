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

            string cariIdQuery = "";
            int id = -1;

            if (jenisKostum == "tradisional")
            {
                cariIdQuery = "SELECT id_kostum_tradisional FROM traditional_costumes WHERE nama_kostum = @nama";
            }
            else if (jenisKostum == "entertainment")
            {
                cariIdQuery = "SELECT id_kostum_entertainment FROM entertainment_costumes WHERE nama_kostum = @nama";
            }
            else
            {
                throw new Exception("Jenis kostum tidak dikenali.");
            }

            // Cari ID berdasarkan jenis
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

            // Insert ke carts sesuai jenis kostum
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;

                if (jenisKostum == "tradisional")
                {
                    cmd.CommandText = "INSERT INTO carts (id_kostum_tradisional, jenis_kostum, jumlah_item) VALUES (@id_kostum, @jenis, @jumlah)";
                    cmd.Parameters.AddWithValue("id_kostum", id);
                }
                else if (jenisKostum == "entertainment")
                {
                    cmd.CommandText = "INSERT INTO carts (id_kostum_entertainment, jenis_kostum, jumlah_item) VALUES (@id_kostum, @jenis, @jumlah)";
                    cmd.Parameters.AddWithValue("id_kostum", id);
                }

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


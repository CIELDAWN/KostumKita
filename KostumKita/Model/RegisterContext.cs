using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace KostumKita.Model
{
    internal class RegisterContext 
    {
        private readonly string connStr;
        public RegisterContext()
        {
            connStr = "Host=localhost;Username=postgres;password=stanley;Database=KostumKita;";
        }
        public bool Register (string username,DateTime tanggal_lahir,string email, string password)
        {
            string query_select = "SELECT * FROM list_user WHERE username = @username AND email=@email";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    object result = cmd.ExecuteScalar()!;
                    int count = (result != null) ? Convert.ToInt32(result) : 0;
                    if(count > 0)
                    {
                        return false;
                    }
                }
             
            }

            string query_insert = "INSERT INTO list_user(username,email,tanggal_lahir,password) VALUES(@username,@email,@tanggal_lahir,@password)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using(NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal_lahir);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        private void CekKoneksi()
        {
            using var conn = new NpgsqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("Koneksi ke database PostgreSQL berhasil","Mission Sukses");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal koneksi ke database."+ ex.Message,"Error");
                
            }

            
        }
    }
}

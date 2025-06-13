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
        public bool Register(string username, DateTime tanggal_lahir, string email, string password)
        {
            string query_select = "SELECT * FROM user_lists WHERE username = @username";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar()!;
                    int count = (result != null) ? Convert.ToInt32(result) : 0;
                    if (count > 0)
                    {
                        return false;
                    }
                }

            }

            string query_insert = "INSERT INTO user_lists(username,email,tanggal_lahir,password) VALUES(@username,@email,@tanggal_lahir,@password)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }  
    }
}

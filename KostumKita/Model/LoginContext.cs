using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    internal class LoginContext
    {
        private readonly string connStr;
        public LoginContext()
        {
            connStr = "Host = localhost; Username = postgres; Password = Sinta2074; Database = KostumKita";
        }

        public bool Validate(string username,string password, out int user_ID)
        {
            user_ID = 0;
            string query = "SELECT user_ID, username FROM list_user WHERE username = @username AND password=@password";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user_ID = reader.GetInt32(0);
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan Sistem" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}

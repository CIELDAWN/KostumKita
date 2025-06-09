    using Npgsql;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace KostumKita.Model
    {
        class TransaksiContext
        {
            public class LaporanData
            {
                private readonly string connStr;
                private NpgsqlConnection conn;

                public LaporanData(string connectionString)
                {
                    connStr = connectionString;
                    conn = new NpgsqlConnection(connStr);
                }

                public DataTable ExecuteQuery(string query, out NpgsqlDataAdapter adapter)
                {
                    conn.Open();
                    adapter = new NpgsqlDataAdapter(query, conn);
                    NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }

                public void SaveChanges(NpgsqlDataAdapter adapter, DataTable table)
                {
                    adapter.Update(table);
                }

                public void Close()
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }
    }

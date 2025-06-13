using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace KostumKita.Model
{
    public class TransaksiItem
    {
        public string NamaKostum { get; set; }
        public string JenisKostum { get; set; }
        public string StatusTransaksi { get; set; }
        public int JumlahItem { get; set; }
        public decimal HargaPerItem { get; set; }
        public decimal TotalHarga { get; set; }
    }

    public class TransaksiKostumerContext // Ubah dari internal ke public
    {
        private readonly string connectionString;

        public TransaksiKostumerContext()
        {
            connectionString = "Host=localhost;Port=5432;Username=postgres;Password=stanley;Database=KostumKita";
        }

        // Method untuk mendapatkan semua item di keranjang
        public List<TransaksiItem> GetItemsKeranjang()
        {
            List<TransaksiItem> items = new List<TransaksiItem>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query untuk mendapatkan item traditional costumes
                    string queryTradisional = @"
                        SELECT 
                            tc.nama_kostum,
                            'Tradisional' as jenis_kostum,
                            c.jenis_kostum as status_transaksi,
                            c.jumlah_item,
                            tc.harga_sewa as harga_per_item
                        FROM carts c
                        INNER JOIN traditional_costumes tc ON c.id_kostum_tradisional = tc.id_kostum_tradisional
                        WHERE c.id_kostum_tradisional IS NOT NULL";

                    using (var cmd = new NpgsqlCommand(queryTradisional, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new TransaksiItem
                                {
                                    NamaKostum = reader["nama_kostum"]?.ToString() ?? "",
                                    JenisKostum = reader["jenis_kostum"]?.ToString() ?? "",
                                    StatusTransaksi = reader["status_transaksi"]?.ToString() ?? "",
                                    JumlahItem = reader["jumlah_item"] != DBNull.Value ? Convert.ToInt32(reader["jumlah_item"]) : 0,
                                    HargaPerItem = reader["harga_per_item"] != DBNull.Value ? Convert.ToDecimal(reader["harga_per_item"]) : 0
                                };
                                item.TotalHarga = item.HargaPerItem * item.JumlahItem;
                                items.Add(item);
                            }
                        }
                    }

                    // Query untuk mendapatkan item entertainment costumes
                    string queryEntertainment = @"
                        SELECT 
                            ec.nama_kostum,
                            'Entertainment' as jenis_kostum,
                            c.jenis_kostum as status_transaksi,
                            c.jumlah_item,
                            CASE 
                                WHEN UPPER(c.jenis_kostum) = 'SEWA' THEN ec.harga_sewa
                                WHEN UPPER(c.jenis_kostum) = 'BELI' THEN ec.harga_beli
                                ELSE ec.harga_sewa
                            END as harga_per_item
                        FROM carts c
                        INNER JOIN entertainment_costumes ec ON c.id_kostum_entertainment = ec.id_kostum_entertainment
                        WHERE c.id_kostum_entertainment IS NOT NULL";

                    using (var cmd = new NpgsqlCommand(queryEntertainment, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new TransaksiItem
                                {
                                    NamaKostum = reader["nama_kostum"]?.ToString() ?? "",
                                    JenisKostum = reader["jenis_kostum"]?.ToString() ?? "",
                                    StatusTransaksi = reader["status_transaksi"]?.ToString() ?? "",
                                    JumlahItem = reader["jumlah_item"] != DBNull.Value ? Convert.ToInt32(reader["jumlah_item"]) : 0,
                                    HargaPerItem = reader["harga_per_item"] != DBNull.Value ? Convert.ToDecimal(reader["harga_per_item"]) : 0
                                };
                                item.TotalHarga = item.HargaPerItem * item.JumlahItem;
                                items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error mengambil data keranjang: {ex.Message}");
                }
            }

            return items;
        }

        // Method untuk mendapatkan total harga keseluruhan
        public decimal GetTotalHargaKeseluruhan()
        {
            var items = GetItemsKeranjang();
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.TotalHarga;
            }
            return total;
        }

        // Method untuk generate kode pembayaran
        public string GenerateKodePembayaran(string metodePembayaran)
        {
            Random random = new Random();
            string kode = "";

            if (string.IsNullOrEmpty(metodePembayaran))
            {
                metodePembayaran = "DEFAULT";
            }

            switch (metodePembayaran.ToUpper())
            {
                case "BNI":
                    kode = "8808" + random.Next(100000, 999999).ToString();
                    break;
                case "BCA":
                    kode = "8808" + random.Next(100000, 999999).ToString();
                    break;
                case "MANDIRI":
                    kode = "8808" + random.Next(100000, 999999).ToString();
                    break;
                case "BRI":
                    kode = "8808" + random.Next(100000, 999999).ToString();
                    break;
                default:
                    kode = "8808" + random.Next(100000, 999999).ToString();
                    break;
            }

            return kode;
        }

        // Method untuk menyimpan transaksi ke database
        public void SimpanTransaksi(List<TransaksiItem> items, string metodePembayaran, string kodePembayaran)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Buat tabel transaksi jika belum ada
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS transaksi (
                            id_transaksi SERIAL PRIMARY KEY,
                            tanggal_transaksi TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            metode_pembayaran VARCHAR(50),
                            kode_pembayaran VARCHAR(20),
                            total_harga DECIMAL(10,2),
                            status_pembayaran VARCHAR(20) DEFAULT 'BERHASIL'
                        )";

                    using (var createCmd = new NpgsqlCommand(createTableQuery, conn))
                    {
                        createCmd.ExecuteNonQuery();
                    }

                    decimal totalHarga = 0;
                    foreach (var item in items)
                    {
                        totalHarga += item.TotalHarga;
                    }

                    string insertQuery = @"
                        INSERT INTO transaksi (metode_pembayaran, kode_pembayaran, total_harga)
                        VALUES (@metode, @kode, @total)";

                    using (var cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@metode", metodePembayaran ?? "");
                        cmd.Parameters.AddWithValue("@kode", kodePembayaran ?? "");
                        cmd.Parameters.AddWithValue("@total", totalHarga);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error menyimpan transaksi: {ex.Message}");
                }
            }
        }

        // Method untuk validasi koneksi database
        public bool TestConnection()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
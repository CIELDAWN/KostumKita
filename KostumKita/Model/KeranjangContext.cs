using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

internal class KeranjangContext
{
    private readonly string connectionString;

    public KeranjangContext()
    {
        connectionString = "Host=localhost;Port=5432;Username=postgres;Password=blackclover1;Database=KostumKita";
    }

    public void TambahKeranjangDariNama(string namaKostum, string jenisKostum, string statusTransaksi = "sewa")
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                string cariIdQuery = "";
                int id = -1;
                string statusDB = statusTransaksi.ToUpper(); // SEWA atau BELI

                // Debug logging
                System.Diagnostics.Debug.WriteLine($"Mencari kostum: {namaKostum}, Jenis: {jenisKostum}, Status: {statusDB}");

                // Validasi dan pengaturan query berdasarkan jenis kostum
                if (jenisKostum.ToLower() == "tradisional")
                {
                    cariIdQuery = "SELECT id_kostum_tradisional FROM traditional_costumes WHERE LOWER(nama_kostum) = LOWER(@nama)";
                    statusDB = "SEWA"; // Traditional selalu sewa
                }
                else if (jenisKostum.ToLower() == "entertainment")
                {
                    cariIdQuery = "SELECT id_kostum_entertainment FROM entertainment_costumes WHERE LOWER(nama_kostum) = LOWER(@nama)";
                    // Status bisa SEWA atau BELI sesuai parameter
                }
                else
                {
                    throw new ArgumentException($"Jenis kostum '{jenisKostum}' tidak dikenali. Gunakan 'tradisional' atau 'entertainment'.");
                }

                // Cari ID berdasarkan nama kostum
                using (var cmd = new NpgsqlCommand(cariIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", namaKostum);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                        System.Diagnostics.Debug.WriteLine($"ID ditemukan: {id}");
                    }
                    else
                    {
                        throw new Exception($"Kostum '{namaKostum}' tidak ditemukan di database.");
                    }
                }

                // Cek apakah item sudah ada di keranjang dengan status yang sama
                string checkExistQuery;
                if (jenisKostum.ToLower() == "tradisional")
                {
                    checkExistQuery = "SELECT jumlah_item FROM carts WHERE id_kostum_tradisional = @id_kostum AND UPPER(jenis_kostum) = @status";
                }
                else
                {
                    checkExistQuery = "SELECT jumlah_item FROM carts WHERE id_kostum_entertainment = @id_kostum AND UPPER(jenis_kostum) = @status";
                }

                using (var checkCmd = new NpgsqlCommand(checkExistQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id_kostum", id);
                    checkCmd.Parameters.AddWithValue("@status", statusDB);
                    var existingItem = checkCmd.ExecuteScalar();

                    System.Diagnostics.Debug.WriteLine($"Existing item: {existingItem}");

                    if (existingItem != null)
                    {
                        // Item sudah ada, update jumlah
                        int currentQty = Convert.ToInt32(existingItem);
                        string updateQuery;

                        if (jenisKostum.ToLower() == "tradisional")
                        {
                            updateQuery = "UPDATE carts SET jumlah_item = @jumlah WHERE id_kostum_tradisional = @id_kostum AND UPPER(jenis_kostum) = @status";
                        }
                        else
                        {
                            updateQuery = "UPDATE carts SET jumlah_item = @jumlah WHERE id_kostum_entertainment = @id_kostum AND UPPER(jenis_kostum) = @status";
                        }

                        using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@jumlah", currentQty + 1);
                            updateCmd.Parameters.AddWithValue("@id_kostum", id);
                            updateCmd.Parameters.AddWithValue("@status", statusDB);
                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            System.Diagnostics.Debug.WriteLine($"Rows updated: {rowsAffected}");
                        }
                    }
                    else
                    {
                        // Item belum ada, insert baru
                        string insertQuery;

                        if (jenisKostum.ToLower() == "tradisional")
                        {
                            insertQuery = "INSERT INTO carts (id_kostum_tradisional, jenis_kostum, jumlah_item) VALUES (@id_kostum, @status, @jumlah)";
                        }
                        else
                        {
                            insertQuery = "INSERT INTO carts (id_kostum_entertainment, jenis_kostum, jumlah_item) VALUES (@id_kostum, @status, @jumlah)";
                        }

                        using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@id_kostum", id);
                            insertCmd.Parameters.AddWithValue("@status", statusDB);
                            insertCmd.Parameters.AddWithValue("@jumlah", 1);
                            int rowsAffected = insertCmd.ExecuteNonQuery();
                            System.Diagnostics.Debug.WriteLine($"Rows inserted: {rowsAffected}");
                        }
                    }
                }

                System.Diagnostics.Debug.WriteLine("Transaksi berhasil!");
            }
            catch (Exception ex)
            {
                // Log detail error untuk debugging
                System.Diagnostics.Debug.WriteLine($"Error Detail: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");

                throw new Exception($"Gagal menambahkan ke keranjang: {ex.Message}");
            }
        }
    }


    // Method tambahan untuk mendapatkan total item di keranjang
    public int GetTotalItemsInCart()
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "SELECT COALESCE(SUM(jumlah_item), 0) FROM carts";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting cart total: {ex.Message}");
                return 0;
            }
        }
    }

    // Method untuk menghapus item dari keranjang
    public void HapusItemDariKeranjang(string namaKostum, string jenisKostum, string statusTransaksi = "sewa")
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                // ✅ Kalau nama dan jenis kosong, hapus semua item
                if (string.IsNullOrWhiteSpace(namaKostum) && string.IsNullOrWhiteSpace(jenisKostum))
                {
                    string deleteAllQuery = "DELETE FROM carts";
                    using (var cmd = new NpgsqlCommand(deleteAllQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    return;
                }

                // Jika tidak kosong, lanjut hapus item spesifik
                string cariIdQuery = "";
                int id = -1;
                string statusDB = statusTransaksi.ToUpper();

                if (jenisKostum.ToLower() == "tradisional")
                {
                    cariIdQuery = "SELECT id_kostum_tradisional FROM traditional_costumes WHERE nama_kostum = @nama";
                    statusDB = "SEWA"; // Traditional selalu sewa
                }
                else if (jenisKostum.ToLower() == "entertainment")
                {
                    cariIdQuery = "SELECT id_kostum_entertainment FROM entertainment_costumes WHERE nama_kostum = @nama";
                }
                else
                {
                    throw new ArgumentException($"Jenis kostum '{jenisKostum}' tidak dikenali.");
                }

                using (var cmd = new NpgsqlCommand(cariIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", namaKostum);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception($"Kostum '{namaKostum}' tidak ditemukan.");
                    }
                }

                string deleteQuery;
                if (jenisKostum.ToLower() == "tradisional")
                {
                    deleteQuery = "DELETE FROM carts WHERE id_kostum_tradisional = @id_kostum AND jenis_kostum = @status";
                }
                else
                {
                    deleteQuery = "DELETE FROM carts WHERE id_kostum_entertainment = @id_kostum AND jenis_kostum = @status";
                }

                using (var deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@id_kostum", id);
                    deleteCmd.Parameters.AddWithValue("@status", statusDB);
                    deleteCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghapus dari keranjang: {ex.Message}");
            }
        }
    }
}
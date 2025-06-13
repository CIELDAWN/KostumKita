using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostumKita
{
    public partial class Update : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=stanley;Database=KostumKita";

        public Update()
        {
            InitializeComponent();
        }
        private string currentTable = "";

        public void Tampilkan(string nama)
        {
            if (string.IsNullOrEmpty(nama))
                return;

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();


                    string queryEntertainment = "SELECT * FROM entertainment_costumes WHERE nama_kostum = @nama";
                    using (var cmd = new NpgsqlCommand(queryEntertainment, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentTable = "entertainment_costumes";

                                tb_nama.Text = reader["nama_kostum"].ToString();
                                tb_sewa.Text = reader["harga_sewa"].ToString();
                                tb_beli.Text = reader["harga_beli"].ToString();
                                tb_stock.Text = reader["jumlah_stok"].ToString();
                                tb_stock.Text = reader["jumlah_stok"].ToString();
                                l_stock.Text = $"Stok Saat Ini: {tb_stock.Text}";
                                tb_asal.Text = "";

                                if (!reader.IsDBNull(reader.GetOrdinal("gambar")))
                                {
                                    byte[] imgBytes = (byte[])reader["gambar"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        b_gambar.Image = Image.FromStream(ms);
                                    }
                                }

                                return;
                            }
                        }
                    }


                    string queryTraditional = "SELECT * FROM traditional_costumes WHERE nama_kostum = @nama";
                    using (var cmd = new NpgsqlCommand(queryTraditional, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentTable = "traditional_costumes";

                                tb_nama.Text = reader["nama_kostum"].ToString();
                                tb_sewa.Text = reader["harga_sewa"].ToString();
                                tb_asal.Text = reader["asal_daerah"].ToString();
                                tb_stock.Text = reader["jumlah_stok"].ToString();
                                tb_stock.Text = reader["jumlah_stok"].ToString();
                                l_stock.Text = $"Stok Saat Ini: {tb_stock.Text}";
                                tb_beli.Text = "";

                                if (!reader.IsDBNull(reader.GetOrdinal("gambar")))
                                {
                                    byte[] imgBytes = (byte[])reader["gambar"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        b_gambar.Image = Image.FromStream(ms);
                                    }
                                }

                                return;
                            }
                        }
                    }

                    MessageBox.Show("Kostum tidak ditemukan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan data: " + ex.Message);
                }
            }
        }

        private void UpdateKostum()
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (currentTable == "entertainment_costumes")
                    {
                        query = @"UPDATE entertainment_costumes 
                          SET harga_sewa = @sewa, harga_beli = @beli, jumlah_stok = @stok, gambar = @gambar 
                          WHERE nama_kostum = @nama";
                    }
                    else if (currentTable == "traditional_costumes")
                    {
                        query = @"UPDATE traditional_costumes 
                          SET harga_sewa = @sewa, asal_daerah = @asal, jumlah_stok = @stok, gambar = @gambar 
                          WHERE nama_kostum = @nama";
                    }
                    else
                    {
                        MessageBox.Show("Kostum tidak dikenali (tidak ada di database)");
                        return;
                    }

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                        cmd.Parameters.AddWithValue("@sewa", decimal.Parse(tb_sewa.Text));
                        cmd.Parameters.AddWithValue("@stok", int.Parse(tb_stock.Text));
                        cmd.Parameters.AddWithValue("@gambar", ImageToByteArray(b_gambar.Image));

                        if (currentTable == "entertainment_costumes")
                            cmd.Parameters.AddWithValue("@beli", decimal.Parse(tb_beli.Text));
                        else if (currentTable == "traditional_costumes")
                            cmd.Parameters.AddWithValue("@asal", tb_asal.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kostum berhasil diperbarui!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update: " + ex.Message);
                }
            }
        }

        private void b_Home_Click(object sender, EventArgs e)
        {
            HomepageAdmin Home = new HomepageAdmin();
            Home.Show();
            Hide();
        }

        private void b_Manage_Click(object sender, EventArgs e)
        {
            ManageCostume Manage = new ManageCostume();
            Manage.Show();
            Hide();
        }

        private void b_tambah_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_stock.Text, out int stok))
            {
                stok++;
                tb_stock.Text = stok.ToString();
                l_stock.Text = $"Stok Saat Ini: {stok}";
            }
        }

        private void b_Kurang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_stock.Text, out int stok) && stok > 0)
            {
                stok--;
                tb_stock.Text = stok.ToString();
                l_stock.Text = $"Stok Saat Ini: {stok}";
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            UpdateKostum();
        }

        private void tb_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Search_Click(object sender, EventArgs e)
        {
            Tampilkan(tb_nama.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCostume manage = new ManageCostume();
            Hide();
            manage.Show();
        }
    }
}

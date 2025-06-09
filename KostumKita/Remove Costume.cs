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
    public partial class Remove_Costume : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita";

        public Remove_Costume()
        {
            InitializeComponent();
        }

        public void HapusKostum(string nama)
        {

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string TableName = null;
                    string Check_Traditional = "SELECT 1 FROM entertainment_costumes WHERE nama_kostum = @nama";
                    using (var cmd = new NpgsqlCommand(Check_Traditional, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TableName = "entertainment_costumes";
                            }
                        }
                    }
                    if (TableName == null)
                    {
                        string Check_Entertaintment = "SELECT 1 FROM traditional_costumes WHERE nama_kostum = @nama";
                        {
                            using (var cmd = new NpgsqlCommand(Check_Entertaintment, conn))
                            {
                                cmd.Parameters.AddWithValue("@nama", nama);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        TableName = "traditional_costumes";
                                    }
                                }
                            }
                        }
                    }

                    if (TableName != null)
                    {
                        string query = $"DELETE FROM {TableName} WHERE nama_kostum = @nama";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", nama);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Kostum Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan kostum: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void Tampilkan(string nama)
        {
            if (string.IsNullOrEmpty(nama))
            {
                b_gambar.Image = null;
                l_Nama.Text = "";
                l_Sewa.Text = "";
                l_harga.Text = "";
                l_asal.Text = "";
                l_Stock.Text = "";
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Cek di entertainment_costumes
                    string queryEntertainment = "SELECT nama_kostum, gambar, harga_sewa, harga_beli, jumlah_stok FROM entertainment_costumes WHERE nama_kostum = @nama";
                    using (var cmd = new NpgsqlCommand(queryEntertainment, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                l_Nama.Text = "Nama: " + reader["nama_kostum"].ToString();
                                l_Sewa.Text = "Harga Sewa: " + reader["harga_sewa"].ToString();
                                l_harga.Text = "Harga Beli: " + reader["harga_beli"].ToString();
                                l_Stock.Text = "Stok: " + reader["jumlah_stok"].ToString();
                                l_asal.Text = "";

                                if (!reader.IsDBNull(1))
                                {
                                    byte[] gambarBytes = (byte[])reader["gambar"];
                                    using (MemoryStream ms = new MemoryStream(gambarBytes))
                                    {
                                        b_gambar.Image = Image.FromStream(ms);
                                    }
                                }
                                return;
                            }
                        }
                    }

                    // Cek di traditional_costumes
                    string queryTraditional = "SELECT nama_kostum, gambar, harga_sewa, asal_daerah, jumlah_stok FROM traditional_costumes WHERE nama_kostum = @nama";
                    using (var cmd = new NpgsqlCommand(queryTraditional, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                l_Nama.Text = "Nama: " + reader["nama_kostum"].ToString();
                                l_Sewa.Text = "Harga Sewa: " + reader["harga_sewa"].ToString();
                                l_asal.Text = "Asal Daerah: " + reader["asal_daerah"].ToString();
                                l_Stock.Text = "Stok: " + reader["jumlah_stok"].ToString();
                                l_harga.Text = "";

                                if (!reader.IsDBNull(1))
                                {
                                    byte[] gambarBytes = (byte[])reader["gambar"];
                                    using (MemoryStream ms = new MemoryStream(gambarBytes))
                                    {
                                        b_gambar.Image = Image.FromStream(ms);
                                    }
                                }
                                return;
                            }
                        }
                    }


                    l_Nama.Text = "Kostum tidak ditemukan";
                    l_Sewa.Text = "";
                    l_harga.Text = "";
                    l_asal.Text = "";
                    l_Stock.Text = "";
                    b_gambar.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil detail kostum: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void b_Home_Click(object sender, EventArgs e)
        {
            HomepageAdmin home = new HomepageAdmin();
            home.Show();
            Hide();
        }

        private void b_Manage_Click(object sender, EventArgs e)
        {
            ManageCostume M = new ManageCostume();
            M.Show();
            Hide();

        }

        private void tb_remove_TextChanged(object sender, EventArgs e)
        {
            string nama = tb_remove.Text;
            Tampilkan(nama);
        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            string nama = tb_remove.Text;

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Silahkan Masukkan Kostum Yang Ingin Di Hapus Terlebih Dahulu", "Isi Kostum Yang Ingin Di Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var confirm = MessageBox.Show($"Apaka Yakin Untuk Menghapus Kostum \"{nama}\"?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                HapusKostum(nama);
            }
        }

        private void b_gambar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Remove_Costume_Load(object sender, EventArgs e)
        {

        }

        private void b_Manage_Sewa_Beli_Click(object sender, EventArgs e)
        {
            ManagePembelianDanPenyewaan manage = new ManagePembelianDanPenyewaan();
            manage.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCostume manage = new ManageCostume();
            manage.Show();
            Hide();
        }

        private void b_Manage_Transaksi_Click(object sender, EventArgs e)
        {
            Laporan_Transaksi lapor = new Laporan_Transaksi();
            lapor.Show();
            Hide();
        }
    }
}

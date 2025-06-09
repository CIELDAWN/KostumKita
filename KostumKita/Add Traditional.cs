using KostumKita;
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
    public partial class Add_Traditional : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=stanley;Database=KostumKita";
        public Add_Traditional()
        {
            InitializeComponent();
        }
        public void TambahKostum(string nama, decimal harga_sewa, string asal, int jumlah_stok, Image gambar)
        {
            string query = "INSERT INTO traditional_costumes(nama_kostum,harga_sewa,asal_daerah,jumlah_stok,gambar) VALUES(@nama, @harga_sewa, @asal, @stok, @gambar)";
            // string query1 = "INSERT INTO traditional_costumes(nama_kostum, asal daerah,harga_sewa,jumlah_stok) VALUES(@nama,@asal,@harga_sewa,@jumlah_stok)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga_sewa", harga_sewa);
                        cmd.Parameters.AddWithValue("asal", asal);
                        cmd.Parameters.AddWithValue("@stok", jumlah_stok);

                        byte[] gambarBytes = ImageToByteArry(gambar);
                        cmd.Parameters.AddWithValue("@gambar", gambarBytes);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Kostum Telah Ditambahkan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan kostum: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_Costume Entert = new Add_Costume();

            cb_category.DropDownStyle = ComboBoxStyle.DropDownList;
            string kategori = cb_category.SelectedItem?.ToString();

            if (kategori == "Traditional")
            {
                Add_Traditional tradi = new Add_Traditional();
                tradi.Show();
                this.Hide();


            }
            else if (kategori == "Entertainment")
            {

                Entert.Show();
                this.Hide();
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            ManageCostume m = new ManageCostume();
            m.Show();
            Hide();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tb_nama.Text;
                decimal harga_sewa = decimal.Parse(tb_sewa.Text);
                string asal = tb_asal.Text;
                int jumlah = int.Parse(tb_stock.Text);
                Image gambar = b_gambar.Image;

                TambahKostum(nama, harga_sewa, asal, jumlah, gambar);

            }
            catch
            {
                MessageBox.Show("Kostum Tidak Berhasil ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_gambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog gambar = new OpenFileDialog();
            gambar.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (gambar.ShowDialog() == DialogResult.OK)
            {
                b_gambar.Image = Image.FromFile(gambar.FileName);
            }
        }
        private byte[] ImageToByteArry(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageAdmin homepage = new HomepageAdmin();
            homepage.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCostume manage = new ManageCostume();
            manage.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagePembelianDanPenyewaan managePembelianDanPenyewaan = new ManagePembelianDanPenyewaan();
            managePembelianDanPenyewaan.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Laporan_Transaksi laporan = new Laporan_Transaksi();
            laporan.Show();
            Hide();
        }
    }
}

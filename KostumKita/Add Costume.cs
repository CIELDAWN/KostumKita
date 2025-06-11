using KostumKita.Model;
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
    public partial class Add_Costume : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita";
        public Add_Costume()
        {
            InitializeComponent();
        }
        public void TambahKostum(string nama, decimal harga_sewa, decimal harga_beli, int jumlah_stok, Image gambar)
        {
            string query = "INSERT INTO entertainment_costumes(nama_kostum,harga_sewa,harga_beli,jumlah_stok,gambar) VALUES(@nama, @harga_sewa, @harga_beli, @stok, @gambar)";
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
                        cmd.Parameters.AddWithValue("@harga_beli", harga_beli);
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

        private void b_PilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog gambar = new OpenFileDialog();
            gambar.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (gambar.ShowDialog() == DialogResult.OK)
            {
                b_PilihGambar.Image = Image.FromFile(gambar.FileName);
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            ManageCostume m = new ManageCostume();
            m.Show();
            Hide();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tb_Nama_Costume.Text;
                decimal harga_sewa = decimal.Parse(tb_Sewa.Text);
                decimal harga_beli = decimal.Parse(tb_Harga.Text);
                int jumlah = int.Parse(tb_stock.Text);
                Image gambar = b_PilihGambar.Image;

                TambahKostum(nama, harga_sewa, harga_beli, jumlah, gambar);

            }
            catch
            {
                MessageBox.Show("Kostum Tidak Berhasil ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                tb_Harga.Enabled = true;
                tb_Sewa.Enabled = true;
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

        private void tb_Nama_Costume_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Costume_Load(object sender, EventArgs e)
        {

        }

        private void ManagePenyewaanPembelian_Click(object sender, EventArgs e)
        {
            ManagePembelianDanPenyewaan managePembelianDanPenyewaan = new ManagePembelianDanPenyewaan();
            managePembelianDanPenyewaan.Show();
            Hide();
        }

        private void ManageTransaksi_Click(object sender, EventArgs e)
        {
            Laporan_Transaksi laporan = new Laporan_Transaksi();
            laporan.Show();
            Hide();
        }
    }
}




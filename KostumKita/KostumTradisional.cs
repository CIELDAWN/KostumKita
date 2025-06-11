using KostumKita.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostumKita
{
    public partial class KostumTradisional : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita";

        public KostumTradisional()
        {
            InitializeComponent();
        }

        private void Home4_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }

        private void KostumTradisional3_Click(object sender, EventArgs e)
        {
            KostumTradisional kostumTradisionalForm = new KostumTradisional();
            kostumTradisionalForm.WindowState = FormWindowState.Maximized;
            kostumTradisionalForm.Show();
            this.Hide();
        }

        private void KostumEntertainment3_Click(object sender, EventArgs e)
        {
            KostumEntertainment kostumEntertainmentForm = new KostumEntertainment();
            kostumEntertainmentForm.WindowState = FormWindowState.Maximized;
            kostumEntertainmentForm.Show();
            this.Hide();
        }

        private void Live3_Click(object sender, EventArgs e)
        {
            Live LiveForm = new Live();
            LiveForm.WindowState = FormWindowState.Maximized;
            LiveForm.Show();
            this.Hide();
        }

        private void keranjang3_Click(object sender, EventArgs e)
        {
            Keranjang keranjangForm = new Keranjang();
            keranjangForm.WindowState = FormWindowState.Maximized;
            keranjangForm.Show();
            this.Hide();
        }

        private void transaksi3_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.WindowState = FormWindowState.Maximized;
            transaksiForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int id_kostum_tradisional = 1; // ID kostum yang diklik
            int jumlah = 1;
            string jenis_kostum = "tradisional"; // harus sesuai isian jenis_kostum di DB

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = "INSERT INTO carts (id_kostum_tradisional,jenis_kostum, jumlah_item) " +
                               "VALUES (@id_kostum_tradisional,jenis_kostum, @jumlah_item)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_kostum_tradisional", id_kostum_tradisional);
                    cmd.Parameters.AddWithValue("jenis_kostum", jenis_kostum);
                    cmd.Parameters.AddWithValue("jumlah_item", jumlah);
                    cmd.ExecuteNonQuery();
                }
            }   
            MessageBox.Show("Kostum dimasukkan ke keranjang!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KostumTradisional_Load(object sender, EventArgs e)
        {
            maincontainer.FlowDirection = FlowDirection.LeftToRight;
            maincontainer.WrapContents = true;
            maincontainer.AutoScroll = true;

            LoadKostumTradisionalMultiplePanels();

           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maincontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HandleKlikKostum(string namaKostum)
        {
            // Karena ini form KostumTradisional, jenis kostum adalah "tradisional"
            string jenisKostum = "tradisional";

            try
            {
                KeranjangContext keranjang = new KeranjangContext();
                keranjang.TambahKeranjangDariNama(namaKostum, jenisKostum);

                MessageBox.Show($"{namaKostum} berhasil ditambahkan ke keranjang untuk penyewaan!",
                "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambahkan {namaKostum} ke keranjang: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKostumTradisionalMultiplePanels()
        {
            try
            {
                maincontainer.Controls.Clear();
                maincontainer.FlowDirection = FlowDirection.LeftToRight;
                maincontainer.WrapContents = true;
                maincontainer.AutoScroll = true;

                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT id_kostum_tradisional, gambar, nama_kostum, asal_daerah, harga_sewa, jumlah_stok FROM traditional_costumes";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image img = null;
                            if (!reader.IsDBNull(reader.GetOrdinal("gambar")))
                            {
                                byte[] imgBytes = (byte[])reader["gambar"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    img = Image.FromStream(ms);
                                }
                            }

                            string nama = reader["nama_kostum"].ToString();
                            string daerah = reader["asal_daerah"].ToString();
                            decimal harga = reader.GetDecimal(reader.GetOrdinal("harga_sewa"));
                            string stok = reader["jumlah_stok"].ToString();

                            Panel produkPanel = new Panel
                            {
                                Width = 360,
                                Height = 180,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10)
                            };

                            PictureBox pb = new PictureBox
                            {
                                Image = img,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Width = 120,
                                Height = 120,
                                Top = 10,
                                Left = 10
                            };

                            Label lblNama = new Label
                            {
                                Text = nama,
                                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                AutoSize = true,
                                ForeColor = Color.Black,
                                Top = 10,
                                Left = 140
                            };

                            lblNama.Cursor = Cursors.Hand;
                            lblNama.ForeColor = Color.Blue; // opsional, kasih warna supaya kelihatan bisa diklik
                            lblNama.Click += (s, e) => HandleKlikKostum(nama);


                            Label lblDaerah = new Label
                            {
                                Text = "Daerah: " + daerah,
                                AutoSize = true,
                                ForeColor = Color.Black,
                                Top = lblNama.Bottom + 5,
                                Left = 140
                            };

                            Label lblHarga = new Label
                            {
                                Text = "Harga: " + harga.ToString("C"),
                                AutoSize = true,
                                ForeColor = Color.Black,
                                Top = lblDaerah.Bottom + 5,
                                Left = 140
                            };

                            Label lblStok = new Label
                            {
                                Text = "Stok: " + stok,
                                AutoSize = true,
                                ForeColor = Color.Black,
                                Top = lblHarga.Bottom + 5,
                                Left = 140
                            };

                            produkPanel.Controls.Add(pb);
                            produkPanel.Controls.Add(lblNama);
                            produkPanel.Controls.Add(lblDaerah);
                            produkPanel.Controls.Add(lblHarga);
                            produkPanel.Controls.Add(lblStok);
                            lblNama.ForeColor = Color.Blue;
                            

                            // (opsional) panel juga bisa diklik
                            produkPanel.Cursor = Cursors.Hand;
                            produkPanel.Click += (s, e) => HandleKlikKostum(nama);
                            maincontainer.Controls.Add(produkPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }
    }
}
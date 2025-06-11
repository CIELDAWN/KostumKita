using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KostumKita;
using KostumKita.Model;
using Npgsql;

namespace KostumKita
{
    public partial class KostumEntertainment : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita";

        public KostumEntertainment()
        {
            InitializeComponent();
        }

        private void AddEntertainmentCostumeToCart(string namaKostum, string jenisTransaksi)
        {
            try
            {
                KeranjangContext keranjang = new KeranjangContext();

                // ✅ PERBAIKAN: Kirim "entertainment" sebagai jenis kostum dan status transaksi yang benar
                keranjang.TambahKeranjangDariNama(namaKostum, "entertainment", jenisTransaksi.ToLower());

                MessageBox.Show($"{namaKostum} berhasil ditambahkan ke keranjang untuk {jenisTransaksi}!",
                                "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error menambahkan ke keranjang: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleKlikKostum(string namaKostum)
        {
            // Tanya user mau beli atau sewa, mirip kode lama
            DialogResult result = MessageBox.Show(
                $"Apakah Anda ingin membeli atau menyewa {namaKostum}?\nKlik Yes untuk 'Beli', No untuk 'Sewa'.",
                "Pilihan Transaksi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddEntertainmentCostumeToCart(namaKostum, "beli");
            }
            else if (result == DialogResult.No)
            {
                AddEntertainmentCostumeToCart(namaKostum, "sewa");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }

        private void Home2_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }

        private void KostumTradisional1_Click(object sender, EventArgs e)
        {
            KostumTradisional kostumTradisionalForm = new KostumTradisional();
            kostumTradisionalForm.WindowState = FormWindowState.Maximized;
            kostumTradisionalForm.Show();
            this.Hide();
        }

        private void KostumEntertainment2_Click(object sender, EventArgs e)
        {
            KostumEntertainment kostumEntertainmentForm = new KostumEntertainment();
            kostumEntertainmentForm.WindowState = FormWindowState.Maximized;
            kostumEntertainmentForm.Show();
            this.Hide();
        }

        private void Live2_Click(object sender, EventArgs e)
        {
            Live LiveForm = new Live();
            LiveForm.WindowState = FormWindowState.Maximized;
            LiveForm.Show();
            this.Hide();
        }

        private void keranjang2_Click(object sender, EventArgs e)
        {
            Keranjang keranjangForm = new Keranjang();
            keranjangForm.WindowState = FormWindowState.Maximized;
            keranjangForm.Show();
            this.Hide();
        }

        private void Transaksi2_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.WindowState = FormWindowState.Maximized;
            transaksiForm.Show();
            this.Hide();
        }

        private void KostumEntertainment_Load(object sender, EventArgs e)
        {
            maincontainer.FlowDirection = FlowDirection.LeftToRight;
            maincontainer.WrapContents = true;
            maincontainer.AutoScroll = true;

            LoadKostumEntertainmentMultiplePanels();
        }

        private void LoadKostumEntertainmentMultiplePanels()
        {
            try
            {
                maincontainer.Controls.Clear();

                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"SELECT id_kostum_entertainment, gambar, nama_kostum, harga_sewa, harga_beli, jumlah_stok 
                             FROM entertainment_costumes";
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
                            decimal hargaSewa = reader.GetDecimal(reader.GetOrdinal("harga_sewa"));
                            decimal hargaBeli = reader.GetDecimal(reader.GetOrdinal("harga_beli"));
                            string stok = reader["jumlah_stok"].ToString();

                            Panel produkPanel = new Panel
                            {
                                Width = 350,
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
                                Margin = new Padding(10),
                                Left = 10,
                                Top = 10
                            };

                            Panel infoPanel = new Panel
                            {
                                Width = 200,
                                Height = 140,
                                Margin = new Padding(10),
                                Left = 140,
                                Top = 10
                            };

                            Label lblNama = new Label
                            {
                                Text = nama,
                                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                ForeColor = Color.Black,
                                AutoSize = true,
                                Top = 0,
                                Left = 0
                            };

                            lblNama.Cursor = Cursors.Hand;
                            lblNama.ForeColor = Color.Blue;
                            lblNama.Click += (s, e) => HandleKlikKostum(nama);

                            Label lblHargaSewa = new Label
                            {
                                Text = "Harga Sewa: " + hargaSewa.ToString("C"),
                                Font = new Font("Segoe UI", 9),
                                ForeColor = Color.Black,
                                AutoSize = true,
                                Top = lblNama.Bottom + 5,
                                Left = 0
                            };

                            Label lblHargaBeli = new Label
                            {
                                Text = "Harga Beli: " + hargaBeli.ToString("C"),
                                Font = new Font("Segoe UI", 9),
                                ForeColor = Color.Black,
                                AutoSize = true,
                                Top = lblHargaSewa.Bottom + 5,
                                Left = 0
                            };

                            Label lblStok = new Label
                            {
                                Text = "Stok: " + stok,
                                Font = new Font("Segoe UI", 9),
                                ForeColor = Color.Black,
                                AutoSize = true,
                                Top = lblHargaBeli.Bottom + 5,
                                Left = 0
                            };

                            infoPanel.Controls.Add(lblNama);
                            infoPanel.Controls.Add(lblHargaSewa);
                            infoPanel.Controls.Add(lblHargaBeli);
                            infoPanel.Controls.Add(lblStok);

                            produkPanel.Controls.Add(pb);
                            produkPanel.Controls.Add(infoPanel);

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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


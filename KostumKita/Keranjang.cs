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
using Npgsql;
using KostumKita.Model;

namespace KostumKita
{
    public partial class Keranjang : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita";

        public Keranjang()
        {
            InitializeComponent();
        }

        private void Home3_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KostumTradisional kostumTradisionalForm = new KostumTradisional();
            kostumTradisionalForm.WindowState = FormWindowState.Maximized;
            kostumTradisionalForm.Show();
            this.Hide();
        }

        private void KostumEntertainment4_Click(object sender, EventArgs e)
        {
            KostumEntertainment kostumEntertainmentForm = new KostumEntertainment();
            kostumEntertainmentForm.WindowState = FormWindowState.Maximized;
            kostumEntertainmentForm.Show();
            this.Hide();
        }

        private void Live4_Click(object sender, EventArgs e)
        {
            Live LiveForm = new Live();
            LiveForm.WindowState = FormWindowState.Maximized;
            LiveForm.Show();
            this.Hide();
        }

        private void Keranjang4_Click(object sender, EventArgs e)
        {
            Keranjang keranjangForm = new Keranjang();
            keranjangForm.WindowState = FormWindowState.Maximized;
            keranjangForm.Show();
            this.Hide();
        }

        private void Transaksi4_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.WindowState = FormWindowState.Maximized;
            transaksiForm.Show();
            this.Hide();
        }

        private void Keranjang_Load(object sender, EventArgs e)
        {
            LoadKeranjang();
        }


        private void LoadKeranjang()
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
                    string query = @"
                    SELECT 
                        c.id_cart, 
                        c.jumlah_item, 
                        t.nama_kostum, 
                        t.asal_daerah, 
                        t.gambar,
                        'tradisional' AS sumber
                    FROM carts c
                    JOIN traditional_costumes t ON c.id_kostum_tradisional = t.id_kostum_tradisional
                    

                    UNION ALL

                    SELECT 
                        c.id_cart, 
                        c.jumlah_item, 
                        e.nama_kostum, 
                        'Entertainment' as asal_daerah,  -- ✅ Gunakan string literal
                        e.gambar,
                        'entertainment' AS sumber
                    FROM carts c
                    JOIN entertainment_costumes e ON c.id_kostum_entertainment = e.id_kostum_entertainment
                    
";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        int count = 0;

                        while (reader.Read())
                        {
                            count++;

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
                            string asal = reader["asal_daerah"].ToString(); // bisa asal daerah atau tema acara
                            int jumlah = reader.GetInt32(reader.GetOrdinal("jumlah_item"));

                            Panel panelKeranjang = new Panel
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
                                Width = 100,
                                Height = 100,
                                Top = 10,
                                Left = 10
                            };

                            Label lblNama = new Label
                            {
                                Text = nama,
                                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                AutoSize = true,
                                Top = 10,
                                Left = 120
                            };

                            Label lblAsal = new Label
                            {
                                Text = "Asal/Tematik: " + asal,
                                AutoSize = true,
                                Top = lblNama.Bottom + 5,
                                Left = 120
                            };

                            Label lblJumlah = new Label
                            {
                                Text = "Jumlah: " + jumlah.ToString(),
                                AutoSize = true,
                                Top = lblAsal.Bottom + 5, // posisi setelah lblAsal
                                Left = 120
                            };

                            panelKeranjang.Controls.Add(pb);
                            panelKeranjang.Controls.Add(lblNama);
                            panelKeranjang.Controls.Add(lblAsal);
                            panelKeranjang.Controls.Add(lblJumlah);

                            maincontainer.Controls.Add(panelKeranjang);
                        }

                        if (count == 0)
                        {
                            MessageBox.Show("Tidak ada data di keranjang.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat keranjang: " + ex.Message);
            }
        }


        private void rkeranjang_Click(object sender, EventArgs e)
        {
            LoadKeranjang();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnDeleteAllItem_Click(object sender, EventArgs e)
        {
            try
            {
                var keranjangContext = new KeranjangContext();
                keranjangContext.HapusItemDariKeranjang("", ""); // trigger penghapusan semua item
                MessageBox.Show("Semua item dalam keranjang berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKeranjang();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.WindowState = FormWindowState.Maximized;
            transaksiForm.Show();
            this.Hide();
        }
    }

    public class ItemKeranjang
    {
        public string NamaKostum { get; set; }
        public string JenisTransaksi { get; set; }
    }
}
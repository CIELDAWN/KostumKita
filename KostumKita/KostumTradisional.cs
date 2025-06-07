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
            int id_kostum_traditional = 1; // ID dari kostum yang diklik
            int jumlah = 1;

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = "INSERT INTO carts (id_kostum_traditional, jumlah, tanggal_ditambahkan) " +
                               "VALUES (@id_kostum, @jumlah, @tanggal)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_kostum", id_kostum_traditional);
                    cmd.Parameters.AddWithValue("jumlah", jumlah);
                    cmd.Parameters.AddWithValue("tanggal", DateTime.Now);

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

        }
    }
}


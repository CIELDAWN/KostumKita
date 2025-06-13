using KostumKita.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KostumKita.Model.CartContext;

namespace KostumKita
{
    public partial class Laporan_Transaksi : Form
    {

        private TransaksiContext.LaporanData db;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Laporan_Transaksi()
        {

            InitializeComponent();
            db = new TransaksiContext.LaporanData("Host=localhost;Username=postgres;Password=stanley;Database=KostumKita");
            this.Load += Laporan_Transaksi_Load;
        }


        private void Laporan_Transaksi_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            try
            {
                string query = "SELECT * FROM transactions ORDER BY id_cart";
                dataTable = db.ExecuteQuery(query, out dataAdapter);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;

                dataGridView1.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                var changes = dataTable.GetChanges();
                if (changes == null)
                {
                    MessageBox.Show("Tidak ada perubahan untuk disimpan.");
                    return;
                }

                db.SaveChanges(dataAdapter, dataTable);
                MessageBox.Show("Data berhasil disimpan ke database.", "Sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Close();
            base.OnFormClosed(e);
        }

        private void b_Home_Click(object sender, EventArgs e)
        {
            HomepageAdmin home = new HomepageAdmin();
            home.Show();
            Hide();
        }

        private void b_Manage_Click(object sender, EventArgs e)
        {
            ManageCostume costume = new ManageCostume();
            costume.Show();
            Hide();
        }

        private void b_Sewa_Beli_Click(object sender, EventArgs e)
        {
            ManagePembelianDanPenyewaan carts = new ManagePembelianDanPenyewaan();
            carts.Show();
            Hide();
        }

        private void b_Transaksi_Click(object sender, EventArgs e)
        {
            Laporan_Transaksi lapor = new Laporan_Transaksi();
            lapor.Show();
            Hide();
        }

        private void Laporan_Transaksi_Load_1(object sender, EventArgs e)
        {

        }
    }
}

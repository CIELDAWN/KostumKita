using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static KostumKita.Model.CartContext;

namespace KostumKita
{
    public partial class ManagePembelianDanPenyewaan : Form
    {
        private DatabaseManager db;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public ManagePembelianDanPenyewaan()
        {
            InitializeComponent();
            db = new DatabaseManager("Host=localhost;Username=postgres;Password=Sinta2074;Database=KostumKita");
            this.Load += ManagePembelianDanPenyewaan_Load;
        }

        private void ManagePembelianDanPenyewaan_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            try
            {
                string query = "SELECT * FROM carts ORDER BY id_cart";
                dataTable = db.ExecuteQuery(query, out dataAdapter);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;

                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
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

        private void b_cancel_Click(object sender, EventArgs e)
        {
            HomepageAdmin admin = new HomepageAdmin();
            admin.Show();
            Hide();
        }

        private void ManagePembelianDanPenyewaan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
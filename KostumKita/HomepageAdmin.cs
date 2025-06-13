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
    public partial class HomepageAdmin : Form
    {
        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomepageAdmin homepageAdminForm = new HomepageAdmin();
            homepageAdminForm.WindowState = FormWindowState.Maximized;
            homepageAdminForm.Show();
            this.Hide();
        }

        private void Manage_Costume_Click(object sender, EventArgs e)
        {
            ManageCostume manageCostume = new ManageCostume();
            manageCostume.WindowState = FormWindowState.Maximized;
            manageCostume.Show();
            this.Hide();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageCostume_Click(object sender, EventArgs e)
        {
            ManageCostume manage = new ManageCostume();
            Hide();
            manage.Show();
        }

        private void btnPembelianDanPenyewaan_Click(object sender, EventArgs e)
        {
            ManagePembelianDanPenyewaan managePembelianDanPenyewaan = new ManagePembelianDanPenyewaan();
            managePembelianDanPenyewaan.Show();
            Hide();

        }

        private void btnManageTransaksi_Click(object sender, EventArgs e)
        {
            Laporan_Transaksi lapor = new Laporan_Transaksi();
            lapor.Show();
            Hide();

        }

        private void HomeAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}

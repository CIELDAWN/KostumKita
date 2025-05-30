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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Home5_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }
    }
}

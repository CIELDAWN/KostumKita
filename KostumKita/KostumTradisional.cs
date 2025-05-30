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
    }
}

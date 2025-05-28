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
    public partial class HomepageKostumer : Form
    {
        public HomepageKostumer()
        {
            InitializeComponent();
        }

        private void HomepageKostumer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void List_Kostum_Click(object sender, EventArgs e)
        {
            ListKostum listKostumForm = new ListKostum();
            listKostumForm.Show();
            this.Hide();
        }

        private void keranjang_Click(object sender, EventArgs e)
        {
            Keranjang KeranjangFrom = new Keranjang();
            KeranjangFrom.Show();
            this.Hide();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            Transaksi TransaksiForm = new Transaksi();
            TransaksiForm.Show();
            this.Hide();

        }

        private void ExploreKostum_Click(object sender, EventArgs e)
        {
            ListKostum listKostumForm = new ListKostum();
            listKostumForm.Show();
            this.Hide();
        }
    }
}


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
            this.WindowState = FormWindowState.Maximized;

            Panel panelHeader = new Panel();
            panelHeader.Height = 100;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.BackColor = Color.DarkRed;

            Panel panelFooter = new Panel();
            panelFooter.Height = 100;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.BackColor = Color.DarkRed;

            Panel scrollPanel = new Panel();
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.AutoScroll = true;
            scrollPanel.BackColor = Color.WhiteSmoke;

            Panel panelHomepage = new Panel();
            panelHomepage.AutoSize = true;
            panelHomepage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHomepage.Dock = DockStyle.Top;
            panelHomepage.BackColor = Color.Transparent;

            // Tambahkan konten ke panelHomepage (misalnya, gambar, card, label, tombol, dsb)
            //panelHomepage.Controls.Add(konten1);
            //panelHomepage.Controls.Add(konten2);
            //panelHomepage.Controls.Add(konten3);

            scrollPanel.Controls.Add(panelHomepage);

            this.Controls.Add(scrollPanel);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
        }

        private void HomepageKostumer_Load(object sender, EventArgs e)
        {

        }

        private void List_Kostum_Click(object sender, EventArgs e)
        {
            KostumEntertainment kostumEntertainmentForm = new KostumEntertainment();
            kostumEntertainmentForm.WindowState = FormWindowState.Maximized;
            kostumEntertainmentForm.Show();
            this.Hide();

        }

        private void keranjang_Click(object sender, EventArgs e)
        {
            Keranjang keranjangForm = new Keranjang();
            keranjangForm.WindowState = FormWindowState.Maximized;
            keranjangForm.Show();
            this.Hide();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.WindowState = FormWindowState.Maximized;
            transaksiForm.Show();
            this.Hide();
        }

        private void ExploreKostum_Click(object sender, EventArgs e)
        {
            KostumEntertainment kostumEntertainmentForm = new KostumEntertainment();
            kostumEntertainmentForm.WindowState = FormWindowState.Maximized;
            kostumEntertainmentForm.Show();
            this.Hide();
        }

        private void panel_homepage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KostumTradisional kostumTradisionalForm = new KostumTradisional();
            kostumTradisionalForm.WindowState = FormWindowState.Maximized;
            kostumTradisionalForm.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomepageKostumer homepageKostumerForm = new HomepageKostumer();
            homepageKostumerForm.WindowState = FormWindowState.Maximized;
            homepageKostumerForm.Show();
            this.Hide();
        }

        private void Live_Click(object sender, EventArgs e)
        {
            Live LiveForm = new Live();
            LiveForm.WindowState = FormWindowState.Maximized;
            LiveForm.Show();
            this.Hide();
        }
    }
}


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

namespace KostumKita
{
    public partial class KostumEntertainment : Form
    {
        public KostumEntertainment()
        {
            InitializeComponent();
        }

        private void HandleKlikKostum(string namaKostum)
        {
            DialogResult result = MessageBox.Show(
                $"Apakah Anda ingin membeli atau menyewa {namaKostum}?",
                "Pilihan Transaksi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            string aksi = (result == DialogResult.Yes) ? "membeli" : "menyewa";

            KeranjangContext keranjang = new KeranjangContext();
            keranjang.TambahKeranjang(namaKostum, aksi);

            MessageBox.Show($"{namaKostum} berhasil ditambahkan ke keranjang untuk {aksi.ToLower()}!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSailorMoon_Click(object sender, EventArgs e)
        {
            HandleKlikKostum("Costume Sailor Moon");
        }
    }
}

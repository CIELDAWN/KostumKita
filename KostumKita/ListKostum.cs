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
    public partial class ListKostum : Form
    {
        public ListKostum()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void ListKostum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void b_Home_Click(object sender, EventArgs e)
        {
            HomepageKostumer Home = new HomepageKostumer();
            Home.Show();
            Hide();
        }
    }
}

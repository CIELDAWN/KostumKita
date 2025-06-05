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
    public partial class ManageCostume : Form
    {
        public ManageCostume()
        {
            InitializeComponent();
        }

        private void ManageCostume_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_Home_Click(object sender, EventArgs e)
        {
            HomepageAdmin Home = new HomepageAdmin();
            Hide();
            Home.Show();
        }

        private void b_Manage_Click(object sender, EventArgs e)
        {
            Hide();
            Show();
        }

        private void b_manage_Cos_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            Hide();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            Add_Costume Add = new Add_Costume();
            Hide();
            Add.Show();

        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            Remove_Costume R = new Remove_Costume();
            Hide();
            R.Show();
        }
    }
}

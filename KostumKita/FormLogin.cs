using KostumKita.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostumKita
{
    public partial class FormLogin : Form
    {
        LoginContext login = new LoginContext();
        public FormLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Username != null && tb_Password != null)
                {
                    string username = tb_Username.Text;
                    string password = tb_Password.Text;

                    if (username == "admin" && password == "admin123")
                    {
                        MessageBox.Show("Login Sukses. Klik untuk Melanjutkan Halaman", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomepageAdmin homepage = new HomepageAdmin();
                        homepage.Show();
                        this.Hide();
                        return;
                    }

                    bool valid = login.Validate(username, password, out int User_ID);
                    {
                        if (valid)
                        {
                            MessageBox.Show("Login Sukses. Klik untuk Melanjutkan Halaman", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HomepageKostumer homepage = new HomepageKostumer();
                            homepage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email atau Password SALAH", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghubungi  database: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister formregister = new FormRegister();
            formregister.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_ShowPassword_Click(object sender, EventArgs e)

        {
            bool isPasswordHidden = tb_Password.UseSystemPasswordChar;
            tb_Password.UseSystemPasswordChar = !isPasswordHidden;
            tb_Password.PasswordChar = isPasswordHidden ? '\0' : '●';

            Image icon = isPasswordHidden ? Properties.Resources.Lock : Properties.Resources.Unlock;
            b_ShowPassword.BackgroundImage = icon;


        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

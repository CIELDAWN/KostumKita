using KostumKita.Model;
using Npgsql;
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
    public partial class FormLogin : Form
    {
        LoginContext login = new LoginContext();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Username != null && tb_Password != null)
                {
                    string username = tb_Username.Text;
                    string password = tb_Password.Text;
                    bool valid = login.Validate(username, password, out int User_ID);
                    {
                        if (valid)
                        {
                            MessageBox.Show("Login Sukses. Klik untuk Melanjutkan Halaman", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }

}

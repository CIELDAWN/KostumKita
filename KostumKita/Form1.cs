using KostumKita.Model;

namespace KostumKita
{
    public partial class Form1 : Form
    {
        RegisterContext Regis = new RegisterContext();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new RegisterContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {   
                if (tb_username != null && tb_email != null && dtp_Tanggal_Lahir != null && tb_Password != null)
                {
                    string username = tb_username.Text;
                    string email = tb_email.Text;
                    DateTime tanggal_lahir =dtp_Tanggal_Lahir.Value;
                    string password = tb_Password.Text;
                    bool isRegistered = Regis.Register(username, tanggal_lahir, email, password);
                    if (isRegistered)
                    {
                        MessageBox.Show("Registrasi Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi Gagal. Silahkan Coba Lagi", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan Sistem:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

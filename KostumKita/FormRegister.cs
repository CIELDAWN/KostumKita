using KostumKita.Model;

namespace KostumKita
{
    public partial class FormRegister : Form
    {
        RegisterContext Regis = new RegisterContext();
        public FormRegister()
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
                    if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) ||
                        email.EndsWith("@yahoo.com", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Email harus  memilki @gmail.com atau @yahoo.com", "Validasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    DateTime tanggal_lahir = dtp_Tanggal_Lahir.Value;
                    DateTime today = DateTime.Today;
                    int age = today.Year - tanggal_lahir.Year;
                    if (tanggal_lahir.Date > today.Date)
                    {
                        MessageBox.Show("Data Tanggal Lahir Invalid", "Silahkan Masukkan Ulang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (age < 18)
                    {
                        MessageBox.Show("Akun Anda Tidak 18 Atau Lebih", "Silahkan Masukkan Kembali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    string password = tb_Password.Text;
                    if (password.Length < 8 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit))
                    {
                        MessageBox.Show("Password Harus Memilki 8 Karakter Atau Lebih dan Menggunakan Angka", "Password Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (tb_Password.Text != tb_ConfirmPassword.Text)
                    {
                        MessageBox.Show("Password Tidak Sama", "Silahkan Masukkan Kembali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool isRegistered = Regis.Register(username, tanggal_lahir, email, password);
                    if (isRegistered)
                    {
                        MessageBox.Show("Registrasi Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLogin formlogin = new FormLogin();
                        formlogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi Gagal. Username sudah digunakan! ", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

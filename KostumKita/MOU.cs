using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KostumKita.Model;

namespace KostumKita
{
    public partial class MOU : Form
    {
        private TransaksiKostumerContext transaksiContext;
        private List<TransaksiItem> itemsKeranjang;
        private string metodePembayaran;
        private string bankTerpilih;
        private string kodePembayaran;

        public MOU(List<TransaksiItem> items, string metode, string bank, string kode)
        {
            InitializeComponent();
            transaksiContext = new TransaksiKostumerContext();
            itemsKeranjang = items;
            metodePembayaran = metode;
            bankTerpilih = bank;
            kodePembayaran = kode;

            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Event handler untuk button cancel
            button2.Click += Button2_Click;

            // Event handler untuk button konfirmasi
            button1.Click += Button1_Click;

            // Event handler untuk checkbox
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;

            // Set initial state - button konfirmasi disabled sampai checkbox dicentang
            button1.Enabled = false;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable button konfirmasi berdasarkan status checkbox
            button1.Enabled = checkBox1.Checked;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kembali ke form transaksi
                this.Hide();
                Transaksi transaksiForm = new Transaksi();
                transaksiForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi checkbox harus dicentang
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("Anda harus menyetujui persyaratan terlebih dahulu!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simpan transaksi ke database
                transaksiContext.SimpanTransaksi(itemsKeranjang, metodePembayaran, kodePembayaran);

                // Tampilkan konfirmasi pembayaran
                decimal totalHarga = transaksiContext.GetTotalHargaKeseluruhan();
                string pesanKonfirmasi = $"Pembayaran Berhasil!\n\n" +
                    $"Metode: {metodePembayaran}\n" +
                    $"Bank: {bankTerpilih}\n" +
                    $"Kode Pembayaran: {kodePembayaran}\n" +
                    $"Total: Rp {totalHarga:N0}\n\n" +
                    $"Silakan lakukan pembayaran sesuai kode di atas.\n" +
                    $"MOU telah disepakati untuk item yang disewa.";

                MessageBox.Show(pesanKonfirmasi, "Konfirmasi Pembayaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan keranjang setelah transaksi berhasil
                BersihkanKeranjang();

                // Kembali ke form transaksi atau home
                this.Hide();
                Transaksi transaksiForm = new Transaksi();
                transaksiForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error melakukan transaksi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BersihkanKeranjang()
        {
            try
            {
                KeranjangContext keranjangContext = new KeranjangContext();
                keranjangContext.HapusItemDariKeranjang("", "", ""); // Hapus semua item
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error membersihkan keranjang: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Override untuk handle form closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Cleanup resources jika diperlukan
            if (transaksiContext != null)
            {
                // Dispose context jika ada method dispose
            }
        }

        private void MOU_Load(object sender, EventArgs e)
        {

        }
    }
}
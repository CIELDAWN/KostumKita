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
using KostumKita.Controls;

namespace KostumKita
{
    public partial class Transaksi : Form
    {
        private TransaksiKostumerContext transaksiContext;
        private List<TransaksiItem> itemsKeranjang;

        public Transaksi()
        {
            InitializeComponent();
            transaksiContext = new TransaksiKostumerContext();
            LoadItemsKeranjang();
            SetupEventHandlers();
        }

        private void LoadItemsKeranjang()
        {
            try
            {
                // Bersihkan flowLayoutPanel terlebih dahulu
                flowLayoutPanel1.Controls.Clear();

                // Ambil data dari database
                itemsKeranjang = transaksiContext.GetItemsKeranjang();

                // Tampilkan setiap item di flowLayoutPanel
                foreach (var item in itemsKeranjang)
                {
                    TransaksiItemControl itemControl = new TransaksiItemControl(item);
                    flowLayoutPanel1.Controls.Add(itemControl);
                }

                // Update total harga
                decimal totalHarga = transaksiContext.GetTotalHargaKeseluruhan();
                textBox1.Text = $"Rp {totalHarga:N0}";
                textBox1.ReadOnly = true;

                // Set label untuk menunjukkan total
                label1.Text = "Total Keseluruhan:";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data keranjang: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Event handler untuk perubahan metode pembayaran
            metodepembayaran.SelectedIndexChanged += MetodePembayaran_SelectedIndexChanged;

            // Event handler untuk tombol konfirmasi
            button1.Click += Button1_Click;
        }

        private void MetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metodepembayaran.SelectedItem != null)
            {
                string selectedMethod = metodepembayaran.SelectedItem.ToString();

                // Tampilkan atau sembunyikan ComboBox bank berdasarkan metode pembayaran
                if (selectedMethod == "Transfer Bank" || selectedMethod == "Virtual Account")
                {
                    bank.Visible = true;
                    bank.Enabled = true;
                }
                else
                {
                    bank.Visible = false;
                    bank.Enabled = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (metodepembayaran.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih metode pembayaran!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bank.Visible && bank.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih bank!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (itemsKeranjang == null || itemsKeranjang.Count == 0)
                {
                    MessageBox.Show("Keranjang kosong! Silakan tambahkan item terlebih dahulu.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proses pembayaran
                string metodePembayaran = metodepembayaran.SelectedItem.ToString();
                string bankTerpilih = bank.SelectedItem?.ToString() ?? "";

                string kodePembayaran = transaksiContext.GenerateKodePembayaran(bankTerpilih);

                // Simpan transaksi ke database
                transaksiContext.SimpanTransaksi(itemsKeranjang, $"{metodePembayaran} - {bankTerpilih}", kodePembayaran);

                // Tampilkan konfirmasi pembayaran
                decimal totalHarga = transaksiContext.GetTotalHargaKeseluruhan();
                string pesanKonfirmasi = $"Pembayaran Berhasil!\n\n" +
                    $"Metode: {metodePembayaran}\n" +
                    $"Bank: {bankTerpilih}\n" +
                    $"Kode Pembayaran: {kodePembayaran}\n" +
                    $"Total: Rp {totalHarga:N0}\n\n" +
                    $"Silakan lakukan pembayaran sesuai kode di atas.";

                MessageBox.Show(pesanKonfirmasi, "Konfirmasi Pembayaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan keranjang setelah transaksi berhasil
                BersihkanKeranjang();

                // Reload data
                LoadItemsKeranjang();
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

        // Event handlers untuk navigasi
        private void Home5_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form Home
                this.Hide();
                // Form home = new Home(); // Sesuaikan dengan nama class form Home Anda
                // home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KostumTradisional5_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form Kostum Tradisional
                this.Hide();
                // Form kostumTradisional = new KostumTradisional(); // Sesuaikan dengan nama class
                // kostumTradisional.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KostumEntertainment_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form Kostum Entertainment
                this.Hide();
                // Form kostumEntertainment = new KostumEntertainment(); // Sesuaikan dengan nama class
                // kostumEntertainment.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Live_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form Live
                this.Hide();
                // Form live = new Live(); // Sesuaikan dengan nama class
                // live.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Keranjang4_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigasi ke form Keranjang
                this.Hide();
                // Form keranjang = new Keranjang(); // Sesuaikan dengan nama class
                // keranjang.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigasi: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Transaksi4_Click(object sender, EventArgs e)
        {
            // Sudah di form transaksi, tidak perlu navigasi
            MessageBox.Show("Anda sudah berada di halaman Transaksi", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
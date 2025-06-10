using System;
using System.Drawing;
using System.Windows.Forms;
using KostumKita.Model;

namespace KostumKita.Controls
{
    public partial class TransaksiItemControl : UserControl
    {
        private TransaksiItem item;

        public TransaksiItemControl(TransaksiItem transaksiItem)
        {
            InitializeComponent();
            this.item = transaksiItem;
            SetupControl();
        }

        private void SetupControl()
        {
            // Set ukuran control
            this.Size = new Size(800, 70);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(5);

            // Panel utama
            Panel mainPanel = new Panel();
            mainPanel.Size = new Size(790, 60);
            mainPanel.Location = new Point(5, 5);
            mainPanel.BackColor = Color.White;

            // Label nama kostum
            Label lblNama = new Label();
            lblNama.Text = item.NamaKostum;
            lblNama.Font = new Font("Arial", 10, FontStyle.Bold);
            lblNama.Location = new Point(10, 10);
            lblNama.Size = new Size(180, 20);
            lblNama.ForeColor = Color.Black;

            // Label jenis kostum
            Label lblJenis = new Label();
            lblJenis.Text = item.JenisKostum;
            lblJenis.Font = new Font("Arial", 9);
            lblJenis.Location = new Point(200, 10);
            lblJenis.Size = new Size(100, 20);
            lblJenis.ForeColor = Color.DarkBlue;

            // Label status transaksi
            Label lblStatus = new Label();
            lblStatus.Text = item.StatusTransaksi;
            lblStatus.Font = new Font("Arial", 9, FontStyle.Bold);
            lblStatus.Location = new Point(310, 10);
            lblStatus.Size = new Size(80, 20);
            lblStatus.ForeColor = item.StatusTransaksi.ToUpper() == "SEWA" ? Color.Orange : Color.Green;

            // Label jumlah
            Label lblJumlah = new Label();
            lblJumlah.Text = $"Qty: {item.JumlahItem}";
            lblJumlah.Font = new Font("Arial", 9);
            lblJumlah.Location = new Point(400, 10);
            lblJumlah.Size = new Size(80, 20);
            lblJumlah.ForeColor = Color.Black;

            // Label harga per item
            Label lblHargaPerItem = new Label();
            lblHargaPerItem.Text = $"Rp {item.HargaPerItem:N0}";
            lblHargaPerItem.Font = new Font("Arial", 9);
            lblHargaPerItem.Location = new Point(10, 35);
            lblHargaPerItem.Size = new Size(150, 20);
            lblHargaPerItem.ForeColor = Color.Gray;

            // Label total harga
            Label lblTotalHarga = new Label();
            lblTotalHarga.Text = $"Total: Rp {item.TotalHarga:N0}";
            lblTotalHarga.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTotalHarga.Location = new Point(600, 20);
            lblTotalHarga.Size = new Size(150, 20);
            lblTotalHarga.ForeColor = Color.Red;
            lblTotalHarga.TextAlign = ContentAlignment.MiddleRight;

            // Garis pembatas
            Panel separator = new Panel();
            separator.Size = new Size(780, 1);
            separator.Location = new Point(5, 58);
            separator.BackColor = Color.LightGray;

            // Tambahkan semua kontrol ke panel utama
            mainPanel.Controls.AddRange(new Control[]
            {
                lblNama, lblJenis, lblStatus, lblJumlah,
                lblHargaPerItem, lblTotalHarga
            });

            // Tambahkan ke control utama
            this.Controls.Add(mainPanel);
            this.Controls.Add(separator);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TransaksiItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TransaksiItemControl";
            this.Size = new System.Drawing.Size(800, 70);
            this.ResumeLayout(false);
        }
    }
}
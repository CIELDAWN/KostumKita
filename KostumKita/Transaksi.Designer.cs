namespace KostumKita
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            Home5 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            bank = new ComboBox();
            metodepembayaran = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Transaksi4 = new Button();
            Keranjang4 = new Button();
            Live = new Button();
            KostumEntertainment = new Button();
            KostumTradisional5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Home5
            // 
            Home5.BackColor = Color.LightCoral;
            Home5.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home5.ForeColor = Color.White;
            Home5.Location = new Point(70, 143);
            Home5.Name = "Home5";
            Home5.Size = new Size(156, 34);
            Home5.TabIndex = 0;
            Home5.Text = "HOME";
            Home5.UseVisualStyleBackColor = false;
            Home5.Click += Home5_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(bank);
            panel1.Controls.Add(metodepembayaran);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(Transaksi4);
            panel1.Controls.Add(Keranjang4);
            panel1.Controls.Add(Live);
            panel1.Controls.Add(KostumEntertainment);
            panel1.Controls.Add(KostumTradisional5);
            panel1.Controls.Add(Home5);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(560, 441);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 441);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(1164, 440);
            button1.Name = "button1";
            button1.Size = new Size(172, 52);
            button1.TabIndex = 9;
            button1.Text = "Konfirmasi Pembayaran";
            button1.UseVisualStyleBackColor = true;
            // 
            // bank
            // 
            bank.FormattingEnabled = true;
            bank.Items.AddRange(new object[] { "BRI", "BCA", "BNI" });
            bank.Location = new Point(309, 469);
            bank.Name = "bank";
            bank.Size = new Size(228, 23);
            bank.TabIndex = 8;
            bank.Text = "Pilihan Bank";
            // 
            // metodepembayaran
            // 
            metodepembayaran.FormattingEnabled = true;
            metodepembayaran.Items.AddRange(new object[] { "Virtual Account", "Transfer Bank" });
            metodepembayaran.Location = new Point(309, 440);
            metodepembayaran.Name = "metodepembayaran";
            metodepembayaran.Size = new Size(228, 23);
            metodepembayaran.TabIndex = 7;
            metodepembayaran.Text = "Metode Pembayaran";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(287, 102);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1060, 321);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Transaksi4
            // 
            Transaksi4.BackColor = Color.LightCoral;
            Transaksi4.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaksi4.ForeColor = Color.White;
            Transaksi4.Location = new Point(71, 599);
            Transaksi4.Name = "Transaksi4";
            Transaksi4.Size = new Size(154, 34);
            Transaksi4.TabIndex = 5;
            Transaksi4.Text = "TRANSAKSI";
            Transaksi4.UseVisualStyleBackColor = false;
            Transaksi4.Click += Transaksi4_Click;
            // 
            // Keranjang4
            // 
            Keranjang4.BackColor = Color.LightCoral;
            Keranjang4.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Keranjang4.ForeColor = Color.White;
            Keranjang4.Location = new Point(70, 505);
            Keranjang4.Name = "Keranjang4";
            Keranjang4.Size = new Size(155, 34);
            Keranjang4.TabIndex = 4;
            Keranjang4.Text = "KERANJANG";
            Keranjang4.UseVisualStyleBackColor = false;
            Keranjang4.Click += Keranjang4_Click;
            // 
            // Live
            // 
            Live.BackColor = Color.LightCoral;
            Live.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Live.ForeColor = Color.White;
            Live.Location = new Point(70, 416);
            Live.Name = "Live";
            Live.Size = new Size(156, 33);
            Live.TabIndex = 3;
            Live.Text = "LIVE";
            Live.UseVisualStyleBackColor = false;
            Live.Click += Live_Click;
            // 
            // KostumEntertainment
            // 
            KostumEntertainment.BackColor = Color.LightCoral;
            KostumEntertainment.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumEntertainment.ForeColor = Color.White;
            KostumEntertainment.Location = new Point(71, 323);
            KostumEntertainment.Name = "KostumEntertainment";
            KostumEntertainment.Size = new Size(155, 34);
            KostumEntertainment.TabIndex = 2;
            KostumEntertainment.Text = "KOSTUM ENTERTAINMENT";
            KostumEntertainment.UseVisualStyleBackColor = false;
            KostumEntertainment.Click += KostumEntertainment_Click;
            // 
            // KostumTradisional5
            // 
            KostumTradisional5.BackColor = Color.LightCoral;
            KostumTradisional5.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumTradisional5.ForeColor = Color.White;
            KostumTradisional5.Location = new Point(71, 233);
            KostumTradisional5.Name = "KostumTradisional5";
            KostumTradisional5.Size = new Size(156, 33);
            KostumTradisional5.TabIndex = 1;
            KostumTradisional5.Text = "KOSTUM TRADISIONAL";
            KostumTradisional5.UseVisualStyleBackColor = false;
            KostumTradisional5.Click += KostumTradisional5_Click;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Transaksi";
            Text = "Transaksi";
            Load += Transaksi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Home5;
        private Panel panel1;
        private Button KostumEntertainment;
        private Button KostumTradisional5;
        private Button Transaksi4;
        private Button Keranjang4;
        private Button Live;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox metodepembayaran;
        private Button button1;
        private ComboBox bank;
        private TextBox textBox1;
        private Label label1;
    }
}
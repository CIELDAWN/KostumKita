namespace KostumKita
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            panel1 = new Panel();
            b_Update = new Button();
            l_stock = new Label();
            b_gambar = new Button();
            b_Kurang = new Button();
            b_tambah = new Button();
            tb_stock = new TextBox();
            tb_asal = new TextBox();
            tb_beli = new TextBox();
            tb_sewa = new TextBox();
            tb_nama = new TextBox();
            b_Transaksi = new Button();
            b_Manage_Sewa_Beli = new Button();
            b_Manage = new Button();
            b_Home = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            b_Search = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(b_Search);
            panel1.Controls.Add(b_Update);
            panel1.Controls.Add(l_stock);
            panel1.Controls.Add(b_gambar);
            panel1.Controls.Add(b_Kurang);
            panel1.Controls.Add(b_tambah);
            panel1.Controls.Add(tb_stock);
            panel1.Controls.Add(tb_asal);
            panel1.Controls.Add(tb_beli);
            panel1.Controls.Add(tb_sewa);
            panel1.Controls.Add(tb_nama);
            panel1.Controls.Add(b_Transaksi);
            panel1.Controls.Add(b_Manage_Sewa_Beli);
            panel1.Controls.Add(b_Manage);
            panel1.Controls.Add(b_Home);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // b_Update
            // 
            b_Update.BackgroundImage = (Image)resources.GetObject("b_Update.BackgroundImage");
            b_Update.BackgroundImageLayout = ImageLayout.Zoom;
            b_Update.Location = new Point(586, 596);
            b_Update.Name = "b_Update";
            b_Update.Size = new Size(176, 52);
            b_Update.TabIndex = 13;
            b_Update.UseVisualStyleBackColor = true;
            b_Update.Click += b_Update_Click;
            // 
            // l_stock
            // 
            l_stock.AutoSize = true;
            l_stock.Location = new Point(663, 508);
            l_stock.Name = "l_stock";
            l_stock.Size = new Size(0, 15);
            l_stock.TabIndex = 12;
            // 
            // b_gambar
            // 
            b_gambar.Location = new Point(728, 181);
            b_gambar.Name = "b_gambar";
            b_gambar.Size = new Size(131, 109);
            b_gambar.TabIndex = 11;
            b_gambar.UseVisualStyleBackColor = true;
            // 
            // b_Kurang
            // 
            b_Kurang.BackgroundImage = (Image)resources.GetObject("b_Kurang.BackgroundImage");
            b_Kurang.BackgroundImageLayout = ImageLayout.Zoom;
            b_Kurang.Location = new Point(692, 544);
            b_Kurang.Name = "b_Kurang";
            b_Kurang.Size = new Size(59, 33);
            b_Kurang.TabIndex = 10;
            b_Kurang.UseVisualStyleBackColor = true;
            b_Kurang.Click += b_Kurang_Click;
            // 
            // b_tambah
            // 
            b_tambah.BackgroundImage = (Image)resources.GetObject("b_tambah.BackgroundImage");
            b_tambah.BackgroundImageLayout = ImageLayout.Stretch;
            b_tambah.Location = new Point(862, 537);
            b_tambah.Name = "b_tambah";
            b_tambah.Size = new Size(49, 46);
            b_tambah.TabIndex = 9;
            b_tambah.UseVisualStyleBackColor = true;
            b_tambah.Click += b_tambah_Click;
            // 
            // tb_stock
            // 
            tb_stock.Location = new Point(779, 550);
            tb_stock.Name = "tb_stock";
            tb_stock.Size = new Size(56, 23);
            tb_stock.TabIndex = 8;
            // 
            // tb_asal
            // 
            tb_asal.Location = new Point(814, 464);
            tb_asal.Name = "tb_asal";
            tb_asal.Size = new Size(192, 23);
            tb_asal.TabIndex = 7;
            // 
            // tb_beli
            // 
            tb_beli.Location = new Point(746, 376);
            tb_beli.Name = "tb_beli";
            tb_beli.Size = new Size(220, 23);
            tb_beli.TabIndex = 6;
            // 
            // tb_sewa
            // 
            tb_sewa.Location = new Point(755, 422);
            tb_sewa.Name = "tb_sewa";
            tb_sewa.Size = new Size(234, 23);
            tb_sewa.TabIndex = 5;
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(728, 129);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(234, 23);
            tb_nama.TabIndex = 4;
            tb_nama.TextChanged += tb_nama_TextChanged;
            // 
            // b_Transaksi
            // 
            b_Transaksi.BackgroundImage = (Image)resources.GetObject("b_Transaksi.BackgroundImage");
            b_Transaksi.BackgroundImageLayout = ImageLayout.Center;
            b_Transaksi.Location = new Point(75, 414);
            b_Transaksi.Name = "b_Transaksi";
            b_Transaksi.Size = new Size(153, 31);
            b_Transaksi.TabIndex = 3;
            b_Transaksi.UseVisualStyleBackColor = true;
            // 
            // b_Manage_Sewa_Beli
            // 
            b_Manage_Sewa_Beli.BackgroundImage = (Image)resources.GetObject("b_Manage_Sewa_Beli.BackgroundImage");
            b_Manage_Sewa_Beli.BackgroundImageLayout = ImageLayout.Center;
            b_Manage_Sewa_Beli.Location = new Point(75, 315);
            b_Manage_Sewa_Beli.Name = "b_Manage_Sewa_Beli";
            b_Manage_Sewa_Beli.Size = new Size(153, 45);
            b_Manage_Sewa_Beli.TabIndex = 2;
            b_Manage_Sewa_Beli.UseVisualStyleBackColor = true;
            // 
            // b_Manage
            // 
            b_Manage.BackgroundImage = (Image)resources.GetObject("b_Manage.BackgroundImage");
            b_Manage.BackgroundImageLayout = ImageLayout.Center;
            b_Manage.Location = new Point(75, 231);
            b_Manage.Name = "b_Manage";
            b_Manage.Size = new Size(153, 31);
            b_Manage.TabIndex = 1;
            b_Manage.UseVisualStyleBackColor = true;
            b_Manage.Click += b_Manage_Click;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.BackgroundImageLayout = ImageLayout.Center;
            b_Home.Location = new Point(75, 143);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(153, 31);
            b_Home.TabIndex = 0;
            b_Home.UseVisualStyleBackColor = true;
            b_Home.Click += b_Home_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // b_Search
            // 
            b_Search.Location = new Point(1035, 131);
            b_Search.Name = "b_Search";
            b_Search.Size = new Size(75, 23);
            b_Search.TabIndex = 14;
            b_Search.Text = "Search";
            b_Search.UseVisualStyleBackColor = true;
            b_Search.Click += b_Search_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Update";
            Text = "Update";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button b_Manage_Sewa_Beli;
        private Button b_Manage;
        private Button b_Home;
        private Button b_Transaksi;
        private TextBox tb_nama;
        private TextBox tb_asal;
        private TextBox tb_beli;
        private TextBox tb_sewa;
        private TextBox tb_stock;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button b_Kurang;
        private Button b_tambah;
        private Button b_gambar;
        private Label l_stock;
        private Button b_Update;
        private Button b_Search;
    }
}
namespace KostumKita
{
    partial class Remove_Costume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Costume));
            panel1 = new Panel();
            l_asal = new Label();
            l_harga = new Label();
            l_Sewa = new Label();
            b_gambar = new Button();
            b_Remove = new Button();
            label1 = new Label();
            tb_remove = new TextBox();
            b_Manage_Transaksi = new Button();
            b_Manage_Sewa_Beli = new Button();
            b_Manage = new Button();
            b_Home = new Button();
            l_Nama = new Label();
            l_Stock = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(l_Stock);
            panel1.Controls.Add(l_Nama);
            panel1.Controls.Add(l_asal);
            panel1.Controls.Add(l_harga);
            panel1.Controls.Add(l_Sewa);
            panel1.Controls.Add(b_gambar);
            panel1.Controls.Add(b_Remove);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_remove);
            panel1.Controls.Add(b_Manage_Transaksi);
            panel1.Controls.Add(b_Manage_Sewa_Beli);
            panel1.Controls.Add(b_Manage);
            panel1.Controls.Add(b_Home);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // l_asal
            // 
            l_asal.AutoSize = true;
            l_asal.Location = new Point(821, 475);
            l_asal.Name = "l_asal";
            l_asal.Size = new Size(0, 15);
            l_asal.TabIndex = 10;
            // 
            // l_harga
            // 
            l_harga.AutoSize = true;
            l_harga.Location = new Point(711, 392);
            l_harga.Name = "l_harga";
            l_harga.Size = new Size(0, 15);
            l_harga.TabIndex = 9;
            // 
            // l_Sewa
            // 
            l_Sewa.AutoSize = true;
            l_Sewa.Location = new Point(757, 439);
            l_Sewa.Name = "l_Sewa";
            l_Sewa.Size = new Size(0, 15);
            l_Sewa.TabIndex = 8;
            // 
            // b_gambar
            // 
            b_gambar.Location = new Point(736, 185);
            b_gambar.Name = "b_gambar";
            b_gambar.Size = new Size(156, 124);
            b_gambar.TabIndex = 7;
            b_gambar.UseVisualStyleBackColor = true;
            b_gambar.Click += b_gambar_Click;
            // 
            // b_Remove
            // 
            b_Remove.Location = new Point(350, 374);
            b_Remove.Name = "b_Remove";
            b_Remove.Size = new Size(86, 33);
            b_Remove.TabIndex = 6;
            b_Remove.Text = "Remove";
            b_Remove.UseVisualStyleBackColor = true;
            b_Remove.Click += b_Remove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 430);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 5;
            label1.Text = "Kostum Yang Ingin Di Hapus";
            // 
            // tb_remove
            // 
            tb_remove.Location = new Point(806, 143);
            tb_remove.Name = "tb_remove";
            tb_remove.Size = new Size(202, 23);
            tb_remove.TabIndex = 4;
            tb_remove.TextChanged += tb_remove_TextChanged;
            // 
            // b_Manage_Transaksi
            // 
            b_Manage_Transaksi.BackgroundImage = (Image)resources.GetObject("b_Manage_Transaksi.BackgroundImage");
            b_Manage_Transaksi.BackgroundImageLayout = ImageLayout.Zoom;
            b_Manage_Transaksi.Location = new Point(74, 414);
            b_Manage_Transaksi.Name = "b_Manage_Transaksi";
            b_Manage_Transaksi.Size = new Size(154, 31);
            b_Manage_Transaksi.TabIndex = 3;
            b_Manage_Transaksi.UseVisualStyleBackColor = true;
            // 
            // b_Manage_Sewa_Beli
            // 
            b_Manage_Sewa_Beli.BackgroundImage = (Image)resources.GetObject("b_Manage_Sewa_Beli.BackgroundImage");
            b_Manage_Sewa_Beli.BackgroundImageLayout = ImageLayout.Zoom;
            b_Manage_Sewa_Beli.Location = new Point(74, 314);
            b_Manage_Sewa_Beli.Name = "b_Manage_Sewa_Beli";
            b_Manage_Sewa_Beli.Size = new Size(154, 44);
            b_Manage_Sewa_Beli.TabIndex = 2;
            b_Manage_Sewa_Beli.UseVisualStyleBackColor = true;
            // 
            // b_Manage
            // 
            b_Manage.BackgroundImage = (Image)resources.GetObject("b_Manage.BackgroundImage");
            b_Manage.BackgroundImageLayout = ImageLayout.Zoom;
            b_Manage.Location = new Point(74, 232);
            b_Manage.Name = "b_Manage";
            b_Manage.Size = new Size(154, 31);
            b_Manage.TabIndex = 1;
            b_Manage.UseVisualStyleBackColor = true;
            b_Manage.Click += b_Manage_Click;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.BackgroundImageLayout = ImageLayout.Zoom;
            b_Home.Location = new Point(74, 143);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(154, 31);
            b_Home.TabIndex = 0;
            b_Home.UseVisualStyleBackColor = true;
            b_Home.Click += b_Home_Click;
            // 
            // l_Nama
            // 
            l_Nama.AutoSize = true;
            l_Nama.Location = new Point(695, 345);
            l_Nama.Name = "l_Nama";
            l_Nama.Size = new Size(0, 15);
            l_Nama.TabIndex = 11;
            // 
            // l_Stock
            // 
            l_Stock.AutoSize = true;
            l_Stock.Location = new Point(681, 523);
            l_Stock.Name = "l_Stock";
            l_Stock.Size = new Size(0, 15);
            l_Stock.TabIndex = 12;
            // 
            // Remove_Costume
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Remove_Costume";
            Text = "Remove_Costume";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button b_Manage;
        private Button b_Home;
        private Button b_Manage_Sewa_Beli;
        private Button b_Manage_Transaksi;
        private Label label1;
        private TextBox tb_remove;
        private Button b_Remove;
        private Button b_gambar;
        private Label l_Sewa;
        private Label l_harga;
        private Label l_asal;
        private Label l_Stock;
        private Label l_Nama;
    }
}
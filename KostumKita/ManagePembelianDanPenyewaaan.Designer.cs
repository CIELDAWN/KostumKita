namespace KostumKita
{
    partial class ManagePembelianDanPenyewaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePembelianDanPenyewaan));
            panel1 = new Panel();
            b_cancel = new Button();
            b_save = new Button();
            dataGridView1 = new DataGridView();
            b_Home = new Button();
            b_Costume = new Button();
            b_Sewa_Beli = new Button();
            b_Transaksi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(b_Transaksi);
            panel1.Controls.Add(b_Sewa_Beli);
            panel1.Controls.Add(b_Costume);
            panel1.Controls.Add(b_Home);
            panel1.Controls.Add(b_cancel);
            panel1.Controls.Add(b_save);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(1, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // b_cancel
            // 
            b_cancel.BackgroundImage = Properties.Resources.Group_472;
            b_cancel.BackgroundImageLayout = ImageLayout.Stretch;
            b_cancel.Location = new Point(998, 551);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(142, 54);
            b_cancel.TabIndex = 2;
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.BackgroundImage = (Image)resources.GetObject("b_save.BackgroundImage");
            b_save.BackgroundImageLayout = ImageLayout.Center;
            b_save.Location = new Point(496, 551);
            b_save.Name = "b_save";
            b_save.Size = new Size(181, 54);
            b_save.TabIndex = 1;
            b_save.UseVisualStyleBackColor = true;
            b_save.Click += b_save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 331);
            dataGridView1.TabIndex = 0;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.BackgroundImageLayout = ImageLayout.Center;
            b_Home.Location = new Point(75, 141);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(155, 33);
            b_Home.TabIndex = 3;
            b_Home.UseVisualStyleBackColor = true;
            // 
            // b_Costume
            // 
            b_Costume.BackgroundImage = (Image)resources.GetObject("b_Costume.BackgroundImage");
            b_Costume.BackgroundImageLayout = ImageLayout.Center;
            b_Costume.Location = new Point(75, 228);
            b_Costume.Name = "b_Costume";
            b_Costume.Size = new Size(156, 34);
            b_Costume.TabIndex = 4;
            b_Costume.UseVisualStyleBackColor = true;
            // 
            // b_Sewa_Beli
            // 
            b_Sewa_Beli.BackgroundImage = (Image)resources.GetObject("b_Sewa_Beli.BackgroundImage");
            b_Sewa_Beli.BackgroundImageLayout = ImageLayout.Center;
            b_Sewa_Beli.Location = new Point(75, 319);
            b_Sewa_Beli.Name = "b_Sewa_Beli";
            b_Sewa_Beli.Size = new Size(156, 42);
            b_Sewa_Beli.TabIndex = 5;
            b_Sewa_Beli.UseVisualStyleBackColor = true;
            // 
            // b_Transaksi
            // 
            b_Transaksi.BackgroundImage = (Image)resources.GetObject("b_Transaksi.BackgroundImage");
            b_Transaksi.BackgroundImageLayout = ImageLayout.Center;
            b_Transaksi.Location = new Point(75, 414);
            b_Transaksi.Name = "b_Transaksi";
            b_Transaksi.Size = new Size(156, 34);
            b_Transaksi.TabIndex = 6;
            b_Transaksi.UseVisualStyleBackColor = true;
            // 
            // ManagePembelianDanPenyewaan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "ManagePembelianDanPenyewaan";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button b_save;
        private Button b_cancel;
        private Button b_Home;
        private Button b_Costume;
        private Button b_Transaksi;
        private Button b_Sewa_Beli;
    }
}
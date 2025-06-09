namespace KostumKita
{
    partial class Laporan_Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan_Transaksi));
            panel1 = new Panel();
            b_Transaksi = new Button();
            b_Sewa_Beli = new Button();
            b_Manage = new Button();
            b_Home = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(b_Transaksi);
            panel1.Controls.Add(b_Sewa_Beli);
            panel1.Controls.Add(b_Manage);
            panel1.Controls.Add(b_Home);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // b_Transaksi
            // 
            b_Transaksi.BackgroundImage = (Image)resources.GetObject("b_Transaksi.BackgroundImage");
            b_Transaksi.BackgroundImageLayout = ImageLayout.Center;
            b_Transaksi.Location = new Point(72, 413);
            b_Transaksi.Name = "b_Transaksi";
            b_Transaksi.Size = new Size(156, 34);
            b_Transaksi.TabIndex = 4;
            b_Transaksi.UseVisualStyleBackColor = true;
            b_Transaksi.Click += b_Transaksi_Click;
            // 
            // b_Sewa_Beli
            // 
            b_Sewa_Beli.BackgroundImage = (Image)resources.GetObject("b_Sewa_Beli.BackgroundImage");
            b_Sewa_Beli.BackgroundImageLayout = ImageLayout.Center;
            b_Sewa_Beli.Location = new Point(72, 319);
            b_Sewa_Beli.Name = "b_Sewa_Beli";
            b_Sewa_Beli.Size = new Size(156, 41);
            b_Sewa_Beli.TabIndex = 3;
            b_Sewa_Beli.UseVisualStyleBackColor = true;
            b_Sewa_Beli.Click += b_Sewa_Beli_Click;
            // 
            // b_Manage
            // 
            b_Manage.BackgroundImage = (Image)resources.GetObject("b_Manage.BackgroundImage");
            b_Manage.BackgroundImageLayout = ImageLayout.Center;
            b_Manage.Location = new Point(72, 233);
            b_Manage.Name = "b_Manage";
            b_Manage.Size = new Size(156, 34);
            b_Manage.TabIndex = 2;
            b_Manage.UseVisualStyleBackColor = true;
            b_Manage.Click += b_Manage_Click;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.BackgroundImageLayout = ImageLayout.Center;
            b_Home.Location = new Point(72, 141);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(156, 34);
            b_Home.TabIndex = 1;
            b_Home.UseVisualStyleBackColor = true;
            b_Home.Click += b_Home_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(792, 367);
            dataGridView1.TabIndex = 0;
            // 
            // Laporan_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Laporan_Transaksi";
            Text = "Laporan_Transaksi";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button b_Home;
        private Button b_Transaksi;
        private Button b_Sewa_Beli;
        private Button b_Manage;
    }
}
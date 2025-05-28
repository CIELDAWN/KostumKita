namespace KostumKita
{
    partial class HomepageKostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageKostumer));
            pictureBox1 = new PictureBox();
            List_Kostum = new Button();
            keranjang = new Button();
            Transaksi = new Button();
            ExploreKostum = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Homepage_Kostumer_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-24, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(769, 998);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // List_Kostum
            // 
            List_Kostum.BackColor = Color.FromArgb(192, 0, 0);
            List_Kostum.BackgroundImage = (Image)resources.GetObject("List_Kostum.BackgroundImage");
            List_Kostum.BackgroundImageLayout = ImageLayout.Zoom;
            List_Kostum.Font = new Font("Britannic Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            List_Kostum.ForeColor = Color.Maroon;
            List_Kostum.Location = new Point(168, 13);
            List_Kostum.Name = "List_Kostum";
            List_Kostum.Size = new Size(55, 24);
            List_Kostum.TabIndex = 1;
            List_Kostum.TextImageRelation = TextImageRelation.ImageBeforeText;
            List_Kostum.UseVisualStyleBackColor = false;
            List_Kostum.Click += List_Kostum_Click;
            // 
            // keranjang
            // 
            keranjang.BackColor = SystemColors.ControlLightLight;
            keranjang.BackgroundImage = (Image)resources.GetObject("keranjang.BackgroundImage");
            keranjang.BackgroundImageLayout = ImageLayout.Zoom;
            keranjang.ForeColor = SystemColors.ControlLightLight;
            keranjang.Location = new Point(257, 13);
            keranjang.Name = "keranjang";
            keranjang.Size = new Size(57, 24);
            keranjang.TabIndex = 2;
            keranjang.UseVisualStyleBackColor = false;
            keranjang.Click += keranjang_Click;
            // 
            // Transaksi
            // 
            Transaksi.BackgroundImage = Properties.Resources.Screenshot_2025_05_28_094540;
            Transaksi.BackgroundImageLayout = ImageLayout.Zoom;
            Transaksi.Location = new Point(347, 13);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(53, 24);
            Transaksi.TabIndex = 3;
            Transaksi.UseVisualStyleBackColor = true;
            Transaksi.Click += Transaksi_Click;
            // 
            // ExploreKostum
            // 
            ExploreKostum.BackColor = Color.Maroon;
            ExploreKostum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExploreKostum.ForeColor = SystemColors.ControlLightLight;
            ExploreKostum.Location = new Point(10, 575);
            ExploreKostum.Name = "ExploreKostum";
            ExploreKostum.Size = new Size(154, 31);
            ExploreKostum.TabIndex = 4;
            ExploreKostum.Text = "Explore Kostum";
            ExploreKostum.UseVisualStyleBackColor = false;
            ExploreKostum.Click += ExploreKostum_Click;
            // 
            // HomepageKostumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(728, 749);
            Controls.Add(ExploreKostum);
            Controls.Add(Transaksi);
            Controls.Add(keranjang);
            Controls.Add(List_Kostum);
            Controls.Add(pictureBox1);
            Name = "HomepageKostumer";
            Text = "HomepageKostumer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button List_Kostum;
        private Button keranjang;
        private Button Transaksi;
        private Button ExploreKostum;
    }
}
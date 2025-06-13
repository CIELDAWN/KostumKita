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
            KostumEntertainment = new Button();
            keranjang = new Button();
            Transaksi = new Button();
            ExploreKostum = new Button();
            b_Exit = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Live = new Button();
            Home = new Button();
            KostumTradisional = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // KostumEntertainment
            // 
            KostumEntertainment.BackColor = Color.LightCoral;
            KostumEntertainment.BackgroundImageLayout = ImageLayout.Zoom;
            KostumEntertainment.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumEntertainment.ForeColor = Color.White;
            KostumEntertainment.Location = new Point(72, 325);
            KostumEntertainment.Name = "KostumEntertainment";
            KostumEntertainment.Size = new Size(152, 31);
            KostumEntertainment.TabIndex = 1;
            KostumEntertainment.Text = "KOSTUM ENTERTAINMENT";
            KostumEntertainment.TextImageRelation = TextImageRelation.ImageBeforeText;
            KostumEntertainment.UseVisualStyleBackColor = false;
            KostumEntertainment.Click += List_Kostum_Click;
            // 
            // keranjang
            // 
            keranjang.BackColor = Color.LightCoral;
            keranjang.BackgroundImageLayout = ImageLayout.Zoom;
            keranjang.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keranjang.ForeColor = SystemColors.ControlLightLight;
            keranjang.Location = new Point(72, 507);
            keranjang.Name = "keranjang";
            keranjang.Size = new Size(152, 30);
            keranjang.TabIndex = 2;
            keranjang.Text = "KERANJANG";
            keranjang.UseVisualStyleBackColor = false;
            keranjang.Click += keranjang_Click;
            // 
            // Transaksi
            // 
            Transaksi.BackColor = Color.LightCoral;
            Transaksi.BackgroundImageLayout = ImageLayout.Zoom;
            Transaksi.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaksi.ForeColor = SystemColors.ButtonHighlight;
            Transaksi.Location = new Point(72, 600);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(152, 31);
            Transaksi.TabIndex = 3;
            Transaksi.Text = "TRANSAKSI";
            Transaksi.UseVisualStyleBackColor = false;
            Transaksi.Click += Transaksi_Click;
            // 
            // ExploreKostum
            // 
            ExploreKostum.BackColor = Color.LightCoral;
            ExploreKostum.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExploreKostum.ForeColor = SystemColors.ControlLightLight;
            ExploreKostum.Location = new Point(701, 616);
            ExploreKostum.Name = "ExploreKostum";
            ExploreKostum.Size = new Size(267, 47);
            ExploreKostum.TabIndex = 4;
            ExploreKostum.Text = "EXPLORE KOSTUM";
            ExploreKostum.UseVisualStyleBackColor = false;
            ExploreKostum.Click += ExploreKostum_Click;
            // 
            // b_Exit
            // 
            b_Exit.BackgroundImage = (Image)resources.GetObject("b_Exit.BackgroundImage");
            b_Exit.BackgroundImageLayout = ImageLayout.Center;
            b_Exit.Location = new Point(1304, 26);
            b_Exit.Name = "b_Exit";
            b_Exit.Size = new Size(37, 36);
            b_Exit.TabIndex = 5;
            b_Exit.UseVisualStyleBackColor = true;
            b_Exit.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.SMEOGA_BNAR;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Live);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(KostumTradisional);
            panel1.Controls.Add(b_Exit);
            panel1.Controls.Add(ExploreKostum);
            panel1.Controls.Add(KostumEntertainment);
            panel1.Controls.Add(keranjang);
            panel1.Controls.Add(Transaksi);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2025_05_30_145933;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1176, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 38);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Live
            // 
            Live.BackColor = Color.LightCoral;
            Live.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Live.ForeColor = Color.White;
            Live.Location = new Point(72, 416);
            Live.Name = "Live";
            Live.Size = new Size(152, 33);
            Live.TabIndex = 8;
            Live.Text = "LIVE";
            Live.UseVisualStyleBackColor = false;
            Live.Click += Live_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.LightCoral;
            Home.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home.ForeColor = Color.White;
            Home.Location = new Point(72, 146);
            Home.Name = "Home";
            Home.Size = new Size(152, 31);
            Home.TabIndex = 7;
            Home.Text = "HOME";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // KostumTradisional
            // 
            KostumTradisional.BackColor = Color.LightCoral;
            KostumTradisional.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumTradisional.ForeColor = Color.White;
            KostumTradisional.Location = new Point(72, 237);
            KostumTradisional.Name = "KostumTradisional";
            KostumTradisional.Size = new Size(152, 30);
            KostumTradisional.TabIndex = 6;
            KostumTradisional.Text = "KOSTUM TRADISIONAL";
            KostumTradisional.UseVisualStyleBackColor = false;
            KostumTradisional.Click += button1_Click_1;
            // 
            // HomepageKostumer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "HomepageKostumer";
            Text = "HomepageKostumer";
            Load += HomepageKostumer_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button KostumEntertainment;
        private Button keranjang;
        private Button Transaksi;
        private Button ExploreKostum;
        private Button b_Exit;
        private Panel panel1;
        private Button KostumTradisional;
        private Button Home;
        private Button Live;
        private PictureBox pictureBox1;
    }
}
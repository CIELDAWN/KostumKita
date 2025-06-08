namespace KostumKita
{
    partial class KostumEntertainment
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
            Home = new PictureBox();
            Home2 = new Button();
            pictureBox1 = new PictureBox();
            KostumTradisional1 = new Button();
            KostumEntertainment2 = new Button();
            Live2 = new Button();
            keranjang2 = new Button();
            Transaksi2 = new Button();
            panel1 = new Panel();
            maincontainer = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Home
            // 
            Home.BackgroundImage = Properties.Resources.Screenshot_2025_05_30_021749;
            Home.BackgroundImageLayout = ImageLayout.Zoom;
            Home.Location = new Point(1293, 25);
            Home.Name = "Home";
            Home.Size = new Size(50, 47);
            Home.TabIndex = 0;
            Home.TabStop = false;
            Home.Click += Home_Click;
            // 
            // Home2
            // 
            Home2.BackColor = Color.LightCoral;
            Home2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home2.ForeColor = Color.White;
            Home2.Location = new Point(75, 142);
            Home2.Name = "Home2";
            Home2.Size = new Size(153, 34);
            Home2.TabIndex = 1;
            Home2.Text = "HOME";
            Home2.UseVisualStyleBackColor = false;
            Home2.Click += Home2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2025_05_30_145933;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1182, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 37);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // KostumTradisional1
            // 
            KostumTradisional1.BackColor = Color.LightCoral;
            KostumTradisional1.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumTradisional1.ForeColor = Color.White;
            KostumTradisional1.Location = new Point(75, 232);
            KostumTradisional1.Name = "KostumTradisional1";
            KostumTradisional1.Size = new Size(153, 30);
            KostumTradisional1.TabIndex = 3;
            KostumTradisional1.Text = "KOSTUM TRADISIONAL";
            KostumTradisional1.UseVisualStyleBackColor = false;
            KostumTradisional1.Click += KostumTradisional1_Click;
            // 
            // KostumEntertainment2
            // 
            KostumEntertainment2.BackColor = Color.LightCoral;
            KostumEntertainment2.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumEntertainment2.ForeColor = Color.White;
            KostumEntertainment2.Location = new Point(75, 320);
            KostumEntertainment2.Name = "KostumEntertainment2";
            KostumEntertainment2.Size = new Size(153, 31);
            KostumEntertainment2.TabIndex = 4;
            KostumEntertainment2.Text = "KOSTUM ENTERTAINMENT";
            KostumEntertainment2.UseVisualStyleBackColor = false;
            KostumEntertainment2.Click += KostumEntertainment2_Click;
            // 
            // Live2
            // 
            Live2.BackColor = Color.LightCoral;
            Live2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Live2.ForeColor = Color.White;
            Live2.Location = new Point(75, 413);
            Live2.Name = "Live2";
            Live2.Size = new Size(153, 31);
            Live2.TabIndex = 5;
            Live2.Text = "LIVE";
            Live2.UseVisualStyleBackColor = false;
            Live2.Click += Live2_Click;
            // 
            // keranjang2
            // 
            keranjang2.BackColor = Color.LightCoral;
            keranjang2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keranjang2.ForeColor = Color.White;
            keranjang2.Location = new Point(75, 502);
            keranjang2.Name = "keranjang2";
            keranjang2.Size = new Size(153, 30);
            keranjang2.TabIndex = 6;
            keranjang2.Text = "KERANJANG";
            keranjang2.UseVisualStyleBackColor = false;
            keranjang2.Click += keranjang2_Click;
            // 
            // Transaksi2
            // 
            Transaksi2.BackColor = Color.LightCoral;
            Transaksi2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaksi2.ForeColor = Color.White;
            Transaksi2.Location = new Point(75, 594);
            Transaksi2.Name = "Transaksi2";
            Transaksi2.Size = new Size(153, 32);
            Transaksi2.TabIndex = 7;
            Transaksi2.Text = "TRANSAKSI";
            Transaksi2.UseVisualStyleBackColor = false;
            Transaksi2.Click += Transaksi2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.BackgroundImage = Properties.Resources.entertainment_kostum;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(maincontainer);
            panel1.Controls.Add(Transaksi2);
            panel1.Controls.Add(keranjang2);
            panel1.Controls.Add(Live2);
            panel1.Controls.Add(KostumEntertainment2);
            panel1.Controls.Add(KostumTradisional1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Home2);
            panel1.Controls.Add(Home);
            panel1.ForeColor = Color.DarkRed;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // maincontainer
            // 
            maincontainer.AutoScroll = true;
            maincontainer.BackColor = Color.White;
            maincontainer.Location = new Point(289, 100);
            maincontainer.Name = "maincontainer";
            maincontainer.Size = new Size(1062, 567);
            maincontainer.TabIndex = 8;
            // 
            // KostumEntertainment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "KostumEntertainment";
            Text = "KostumEntertainment";
            Load += KostumEntertainment_Load;
            ((System.ComponentModel.ISupportInitialize)Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Home;
        private Button Home2;
        private PictureBox pictureBox1;
        private Button KostumTradisional1;
        private Button KostumEntertainment2;
        private Button Live2;
        private Button keranjang2;
        private Button Transaksi2;
        private Panel panel1;
        private FlowLayoutPanel maincontainer;
    }
}
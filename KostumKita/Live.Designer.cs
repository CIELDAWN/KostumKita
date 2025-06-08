namespace KostumKita
{
    partial class Live
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Live));
            Home4 = new Button();
            panel1 = new Panel();
            Transaksi6 = new Button();
            Keranjang6 = new Button();
            Live6 = new Button();
            KostumEntertainment6 = new Button();
            KostumTradisional = new Button();
            Home6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Home4
            // 
            Home4.BackColor = Color.LightCoral;
            Home4.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home4.ForeColor = Color.White;
            Home4.Location = new Point(52, 35);
            Home4.Name = "Home4";
            Home4.Size = new Size(108, 32);
            Home4.TabIndex = 0;
            Home4.Text = "HOME";
            Home4.UseVisualStyleBackColor = false;
            Home4.Click += Home4_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Transaksi6);
            panel1.Controls.Add(Keranjang6);
            panel1.Controls.Add(Live6);
            panel1.Controls.Add(KostumEntertainment6);
            panel1.Controls.Add(KostumTradisional);
            panel1.Controls.Add(Home6);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 1;
            // 
            // Transaksi6
            // 
            Transaksi6.BackColor = Color.LightCoral;
            Transaksi6.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Transaksi6.ForeColor = Color.White;
            Transaksi6.ImageAlign = ContentAlignment.BottomRight;
            Transaksi6.Location = new Point(74, 592);
            Transaksi6.Name = "Transaksi6";
            Transaksi6.Size = new Size(154, 33);
            Transaksi6.TabIndex = 5;
            Transaksi6.Text = "TRANSAKSI\r\n";
            Transaksi6.UseVisualStyleBackColor = false;
            Transaksi6.Click += Transaksi6_Click;
            // 
            // Keranjang6
            // 
            Keranjang6.BackColor = Color.LightCoral;
            Keranjang6.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Keranjang6.ForeColor = Color.White;
            Keranjang6.Location = new Point(74, 502);
            Keranjang6.Name = "Keranjang6";
            Keranjang6.Size = new Size(154, 31);
            Keranjang6.TabIndex = 4;
            Keranjang6.Text = "KERANJANG";
            Keranjang6.UseVisualStyleBackColor = false;
            Keranjang6.Click += Keranjang6_Click;
            // 
            // Live6
            // 
            Live6.BackColor = Color.LightCoral;
            Live6.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Live6.ForeColor = Color.White;
            Live6.Location = new Point(74, 412);
            Live6.Name = "Live6";
            Live6.Size = new Size(154, 34);
            Live6.TabIndex = 3;
            Live6.Text = "LIVE";
            Live6.UseVisualStyleBackColor = false;
            Live6.Click += Live6_Click;
            // 
            // KostumEntertainment6
            // 
            KostumEntertainment6.BackColor = Color.LightCoral;
            KostumEntertainment6.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumEntertainment6.ForeColor = Color.White;
            KostumEntertainment6.Location = new Point(74, 322);
            KostumEntertainment6.Name = "KostumEntertainment6";
            KostumEntertainment6.Size = new Size(154, 31);
            KostumEntertainment6.TabIndex = 2;
            KostumEntertainment6.Text = "KOSTUM ENTERTAINMENT";
            KostumEntertainment6.UseVisualStyleBackColor = false;
            KostumEntertainment6.Click += KostumEntertainment6_Click;
            // 
            // KostumTradisional
            // 
            KostumTradisional.BackColor = Color.LightCoral;
            KostumTradisional.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KostumTradisional.ForeColor = Color.White;
            KostumTradisional.Location = new Point(74, 233);
            KostumTradisional.Name = "KostumTradisional";
            KostumTradisional.Size = new Size(154, 31);
            KostumTradisional.TabIndex = 1;
            KostumTradisional.Text = "KOSTUM TRADISIONAL";
            KostumTradisional.UseVisualStyleBackColor = false;
            KostumTradisional.Click += KostumTradisional_Click;
            // 
            // Home6
            // 
            Home6.BackColor = Color.LightCoral;
            Home6.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home6.ForeColor = Color.White;
            Home6.Location = new Point(74, 143);
            Home6.Name = "Home6";
            Home6.Size = new Size(154, 31);
            Home6.TabIndex = 0;
            Home6.Text = "HOME";
            Home6.UseVisualStyleBackColor = false;
            Home6.Click += button1_Click;
            // 
            // Live
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(Home4);
            Name = "Live";
            Text = "Live";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Home4;
        private Panel panel1;
        private Button Home6;
        private Button KostumEntertainment6;
        private Button KostumTradisional;
        private Button Transaksi6;
        private Button Keranjang6;
        private Button Live6;
    }
}
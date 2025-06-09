namespace KostumKita
{
    partial class HomepageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageAdmin));
            panel1 = new Panel();
            b_exit = new Button();
            btnManageTransaksi = new Button();
            btnPembelianDanPenyewaan = new Button();
            btnManageCostume = new Button();
            HomeAdmin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(b_exit);
            panel1.Controls.Add(btnManageTransaksi);
            panel1.Controls.Add(btnPembelianDanPenyewaan);
            panel1.Controls.Add(btnManageCostume);
            panel1.Controls.Add(HomeAdmin);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // b_exit
            // 
            b_exit.BackgroundImage = Properties.Resources.power_off_1;
            b_exit.BackgroundImageLayout = ImageLayout.Zoom;
            b_exit.Location = new Point(1302, 29);
            b_exit.Name = "b_exit";
            b_exit.Size = new Size(43, 40);
            b_exit.TabIndex = 6;
            b_exit.UseVisualStyleBackColor = true;
            b_exit.Click += b_exit_Click;
            // 
            // btnManageTransaksi
            // 
            btnManageTransaksi.BackColor = Color.LightCoral;
            btnManageTransaksi.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageTransaksi.ForeColor = Color.White;
            btnManageTransaksi.Location = new Point(75, 413);
            btnManageTransaksi.Name = "btnManageTransaksi";
            btnManageTransaksi.Size = new Size(153, 34);
            btnManageTransaksi.TabIndex = 5;
            btnManageTransaksi.Text = "MANAGE TRANSAKSI";
            btnManageTransaksi.UseCompatibleTextRendering = true;
            btnManageTransaksi.UseVisualStyleBackColor = false;
            btnManageTransaksi.Click += btnManageTransaksi_Click;
            // 
            // btnPembelianDanPenyewaan
            // 
            btnPembelianDanPenyewaan.BackColor = Color.LightCoral;
            btnPembelianDanPenyewaan.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPembelianDanPenyewaan.ForeColor = Color.White;
            btnPembelianDanPenyewaan.Location = new Point(75, 317);
            btnPembelianDanPenyewaan.Name = "btnPembelianDanPenyewaan";
            btnPembelianDanPenyewaan.Size = new Size(153, 44);
            btnPembelianDanPenyewaan.TabIndex = 4;
            btnPembelianDanPenyewaan.Text = "MANAGE PEMBELIAN DAN PENYEWAAN";
            btnPembelianDanPenyewaan.UseVisualStyleBackColor = false;
            btnPembelianDanPenyewaan.Click += btnPembelianDanPenyewaan_Click;
            // 
            // btnManageCostume
            // 
            btnManageCostume.BackColor = Color.LightCoral;
            btnManageCostume.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageCostume.ForeColor = Color.White;
            btnManageCostume.Location = new Point(75, 231);
            btnManageCostume.Name = "btnManageCostume";
            btnManageCostume.Size = new Size(153, 34);
            btnManageCostume.TabIndex = 3;
            btnManageCostume.Text = "MANAGE COSTUME";
            btnManageCostume.UseVisualStyleBackColor = false;
            btnManageCostume.Click += btnManageCostume_Click;
            // 
            // HomeAdmin
            // 
            HomeAdmin.BackColor = Color.LightCoral;
            HomeAdmin.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeAdmin.ForeColor = Color.White;
            HomeAdmin.Location = new Point(75, 142);
            HomeAdmin.Name = "HomeAdmin";
            HomeAdmin.Size = new Size(153, 34);
            HomeAdmin.TabIndex = 2;
            HomeAdmin.Text = "HOME";
            HomeAdmin.UseVisualStyleBackColor = false;
            // 
            // HomepageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "HomepageAdmin";
            Text = "HomepageAdmin";
            Load += HomepageAdmin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button HomeAdmin;
        private Button btnManageTransaksi;
        private Button btnPembelianDanPenyewaan;
        private Button btnManageCostume;
        private Button b_exit;
    }
}
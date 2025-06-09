namespace KostumKita
{
    partial class ManageCostume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCostume));
            panel1 = new Panel();
            b_Transaksi = new Button();
            b_Manage_Sewa_Beli = new Button();
            b_manage_Cos = new Button();
            b_Remove = new Button();
            b_Add = new Button();
            b_Manage = new Button();
            b_Home = new Button();
            b_exit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(b_Transaksi);
            panel1.Controls.Add(b_Manage_Sewa_Beli);
            panel1.Controls.Add(b_manage_Cos);
            panel1.Controls.Add(b_Remove);
            panel1.Controls.Add(b_Add);
            panel1.Controls.Add(b_Manage);
            panel1.Controls.Add(b_Home);
            panel1.Controls.Add(b_exit);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // b_Transaksi
            // 
            b_Transaksi.BackgroundImage = (Image)resources.GetObject("b_Transaksi.BackgroundImage");
            b_Transaksi.Location = new Point(73, 414);
            b_Transaksi.Name = "b_Transaksi";
            b_Transaksi.Size = new Size(155, 32);
            b_Transaksi.TabIndex = 7;
            b_Transaksi.UseVisualStyleBackColor = true;
            b_Transaksi.Click += b_Transaksi_Click;
            // 
            // b_Manage_Sewa_Beli
            // 
            b_Manage_Sewa_Beli.BackgroundImage = (Image)resources.GetObject("b_Manage_Sewa_Beli.BackgroundImage");
            b_Manage_Sewa_Beli.BackgroundImageLayout = ImageLayout.Center;
            b_Manage_Sewa_Beli.Location = new Point(73, 320);
            b_Manage_Sewa_Beli.Name = "b_Manage_Sewa_Beli";
            b_Manage_Sewa_Beli.Size = new Size(155, 38);
            b_Manage_Sewa_Beli.TabIndex = 6;
            b_Manage_Sewa_Beli.UseVisualStyleBackColor = true;
            b_Manage_Sewa_Beli.Click += b_Manage_Sewa_Beli_Click;
            // 
            // b_manage_Cos
            // 
            b_manage_Cos.BackgroundImage = (Image)resources.GetObject("b_manage_Cos.BackgroundImage");
            b_manage_Cos.Location = new Point(1083, 361);
            b_manage_Cos.Name = "b_manage_Cos";
            b_manage_Cos.Size = new Size(191, 35);
            b_manage_Cos.TabIndex = 5;
            b_manage_Cos.Text = " ";
            b_manage_Cos.UseVisualStyleBackColor = true;
            b_manage_Cos.Click += b_manage_Cos_Click;
            // 
            // b_Remove
            // 
            b_Remove.BackgroundImage = (Image)resources.GetObject("b_Remove.BackgroundImage");
            b_Remove.Location = new Point(755, 361);
            b_Remove.Name = "b_Remove";
            b_Remove.Size = new Size(191, 35);
            b_Remove.TabIndex = 4;
            b_Remove.UseVisualStyleBackColor = true;
            b_Remove.Click += b_Remove_Click;
            // 
            // b_Add
            // 
            b_Add.BackgroundImage = (Image)resources.GetObject("b_Add.BackgroundImage");
            b_Add.Location = new Point(430, 361);
            b_Add.Name = "b_Add";
            b_Add.Size = new Size(191, 35);
            b_Add.TabIndex = 3;
            b_Add.UseVisualStyleBackColor = true;
            b_Add.Click += b_Add_Click;
            // 
            // b_Manage
            // 
            b_Manage.BackgroundImage = (Image)resources.GetObject("b_Manage.BackgroundImage");
            b_Manage.Location = new Point(73, 233);
            b_Manage.Name = "b_Manage";
            b_Manage.Size = new Size(155, 32);
            b_Manage.TabIndex = 2;
            b_Manage.UseVisualStyleBackColor = true;
            b_Manage.Click += b_Manage_Click;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.Location = new Point(73, 144);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(155, 32);
            b_Home.TabIndex = 1;
            b_Home.UseVisualStyleBackColor = true;
            b_Home.Click += b_Home_Click;
            // 
            // b_exit
            // 
            b_exit.BackgroundImage = Properties.Resources.power_off_11;
            b_exit.BackgroundImageLayout = ImageLayout.Zoom;
            b_exit.Location = new Point(1308, 32);
            b_exit.Name = "b_exit";
            b_exit.Size = new Size(36, 36);
            b_exit.TabIndex = 0;
            b_exit.UseVisualStyleBackColor = true;
            b_exit.Click += b_exit_Click;
            // 
            // ManageCostume
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "ManageCostume";
            Text = "ManageCostume";
            Load += ManageCostume_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button b_exit;
        private Button b_Home;
        private Button b_Manage;
        private Button b_Add;
        private Button b_Remove;
        private Button b_manage_Cos;
        private Button b_Manage_Sewa_Beli;
        private Button b_Transaksi;
    }
}
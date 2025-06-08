namespace KostumKita
{
    partial class Add_Costume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Costume));
            panel1 = new Panel();
            label1 = new Label();
            cb_category = new ComboBox();
            tb_Sewa = new TextBox();
            b_Cancel = new Button();
            b_Save = new Button();
            tb_stock = new TextBox();
            tb_Harga = new TextBox();
            tb_Nama_Costume = new TextBox();
            b_PilihGambar = new Button();
            b_Manage = new Button();
            b_Home = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cb_category);
            panel1.Controls.Add(tb_Sewa);
            panel1.Controls.Add(b_Cancel);
            panel1.Controls.Add(b_Save);
            panel1.Controls.Add(tb_stock);
            panel1.Controls.Add(tb_Harga);
            panel1.Controls.Add(tb_Nama_Costume);
            panel1.Controls.Add(b_PilihGambar);
            panel1.Controls.Add(b_Manage);
            panel1.Controls.Add(b_Home);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(586, 160);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 13;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Items.AddRange(new object[] { "Entertainment", "Traditional" });
            cb_category.Location = new Point(700, 134);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(227, 23);
            cb_category.TabIndex = 12;
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            // 
            // tb_Sewa
            // 
            tb_Sewa.Location = new Point(747, 472);
            tb_Sewa.Name = "tb_Sewa";
            tb_Sewa.Size = new Size(269, 23);
            tb_Sewa.TabIndex = 11;
            // 
            // b_Cancel
            // 
            b_Cancel.BackgroundImage = Properties.Resources.Group_472;
            b_Cancel.BackgroundImageLayout = ImageLayout.Zoom;
            b_Cancel.Location = new Point(851, 551);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(176, 55);
            b_Cancel.TabIndex = 7;
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Click += b_Cancel_Click;
            // 
            // b_Save
            // 
            b_Save.BackgroundImage = (Image)resources.GetObject("b_Save.BackgroundImage");
            b_Save.BackgroundImageLayout = ImageLayout.Center;
            b_Save.Location = new Point(597, 551);
            b_Save.Name = "b_Save";
            b_Save.Size = new Size(179, 55);
            b_Save.TabIndex = 6;
            b_Save.UseVisualStyleBackColor = true;
            b_Save.Click += b_Save_Click;
            // 
            // tb_stock
            // 
            tb_stock.Location = new Point(700, 511);
            tb_stock.Name = "tb_stock";
            tb_stock.Size = new Size(260, 23);
            tb_stock.TabIndex = 5;
            tb_stock.TextChanged += tb_size_TextChanged;
            // 
            // tb_Harga
            // 
            tb_Harga.Location = new Point(712, 422);
            tb_Harga.Name = "tb_Harga";
            tb_Harga.Size = new Size(304, 23);
            tb_Harga.TabIndex = 4;
            // 
            // tb_Nama_Costume
            // 
            tb_Nama_Costume.Location = new Point(700, 378);
            tb_Nama_Costume.Name = "tb_Nama_Costume";
            tb_Nama_Costume.Size = new Size(316, 23);
            tb_Nama_Costume.TabIndex = 3;
            tb_Nama_Costume.TextChanged += tb_Nama_Costume_TextChanged;
            // 
            // b_PilihGambar
            // 
            b_PilihGambar.BackgroundImageLayout = ImageLayout.Center;
            b_PilihGambar.Location = new Point(747, 220);
            b_PilihGambar.Name = "b_PilihGambar";
            b_PilihGambar.Size = new Size(127, 114);
            b_PilihGambar.TabIndex = 2;
            b_PilihGambar.UseVisualStyleBackColor = true;
            b_PilihGambar.Click += b_PilihGambar_Click;
            // 
            // b_Manage
            // 
            b_Manage.BackgroundImage = (Image)resources.GetObject("b_Manage.BackgroundImage");
            b_Manage.Location = new Point(77, 233);
            b_Manage.Name = "b_Manage";
            b_Manage.Size = new Size(154, 31);
            b_Manage.TabIndex = 1;
            b_Manage.UseVisualStyleBackColor = true;
            b_Manage.Click += b_Manage_Click;
            // 
            // b_Home
            // 
            b_Home.BackgroundImage = (Image)resources.GetObject("b_Home.BackgroundImage");
            b_Home.BackgroundImageLayout = ImageLayout.Center;
            b_Home.Location = new Point(72, 144);
            b_Home.Name = "b_Home";
            b_Home.Size = new Size(159, 31);
            b_Home.TabIndex = 0;
            b_Home.UseVisualStyleBackColor = true;
            b_Home.Click += b_Home_Click;
            // 
            // Add_Costume
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Add_Costume";
            Text = "Add_Costume";
            Load += Add_Costume_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button b_Manage;
        private Button b_Home;
        private Button b_PilihGambar;
        private TextBox tb_Harga;
        private TextBox tb_Nama_Costume;
        private TextBox tb_stock;
        private Button b_Cancel;
        private Button b_Save;
        private TextBox tb_Sewa;
        private ComboBox cb_category;
        private Label label1;
    }
}
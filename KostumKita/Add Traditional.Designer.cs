namespace KostumKita
{
    partial class Add_Traditional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Traditional));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            b_cancel = new Button();
            b_save = new Button();
            tb_stock = new TextBox();
            tb_asal = new TextBox();
            tb_sewa = new TextBox();
            tb_nama = new TextBox();
            cb_category = new ComboBox();
            b_gambar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(b_cancel);
            panel1.Controls.Add(b_save);
            panel1.Controls.Add(tb_stock);
            panel1.Controls.Add(tb_asal);
            panel1.Controls.Add(tb_sewa);
            panel1.Controls.Add(tb_nama);
            panel1.Controls.Add(cb_category);
            panel1.Controls.Add(b_gambar);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(74, 412);
            button4.Name = "button4";
            button4.Size = new Size(156, 36);
            button4.TabIndex = 11;
            button4.Text = "MANAGE TRANSAKSI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(74, 316);
            button3.Name = "button3";
            button3.Size = new Size(154, 44);
            button3.TabIndex = 10;
            button3.Text = "MANAGE PENYEWAAN DAN PEMBELIAN";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(76, 231);
            button2.Name = "button2";
            button2.Size = new Size(154, 33);
            button2.TabIndex = 9;
            button2.Text = "MANAGE COSTUME";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 143);
            button1.Name = "button1";
            button1.Size = new Size(154, 31);
            button1.TabIndex = 8;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // b_cancel
            // 
            b_cancel.BackgroundImage = (Image)resources.GetObject("b_cancel.BackgroundImage");
            b_cancel.BackgroundImageLayout = ImageLayout.Zoom;
            b_cancel.Location = new Point(848, 552);
            b_cancel.Name = "b_cancel";
            b_cancel.Size = new Size(182, 49);
            b_cancel.TabIndex = 7;
            b_cancel.UseVisualStyleBackColor = true;
            b_cancel.Click += b_cancel_Click;
            // 
            // b_save
            // 
            b_save.BackgroundImage = (Image)resources.GetObject("b_save.BackgroundImage");
            b_save.BackgroundImageLayout = ImageLayout.Zoom;
            b_save.Location = new Point(595, 552);
            b_save.Name = "b_save";
            b_save.Size = new Size(180, 49);
            b_save.TabIndex = 6;
            b_save.UseVisualStyleBackColor = true;
            b_save.Click += b_save_Click;
            // 
            // tb_stock
            // 
            tb_stock.Location = new Point(673, 515);
            tb_stock.Name = "tb_stock";
            tb_stock.Size = new Size(337, 23);
            tb_stock.TabIndex = 5;
            // 
            // tb_asal
            // 
            tb_asal.Location = new Point(819, 470);
            tb_asal.Name = "tb_asal";
            tb_asal.Size = new Size(196, 23);
            tb_asal.TabIndex = 4;
            // 
            // tb_sewa
            // 
            tb_sewa.Location = new Point(751, 422);
            tb_sewa.Name = "tb_sewa";
            tb_sewa.Size = new Size(268, 23);
            tb_sewa.TabIndex = 3;
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(706, 375);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(302, 23);
            tb_nama.TabIndex = 2;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Items.AddRange(new object[] { "Entertainment", "Traditional" });
            cb_category.Location = new Point(706, 131);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(270, 23);
            cb_category.TabIndex = 1;
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            // 
            // b_gambar
            // 
            b_gambar.Location = new Point(752, 212);
            b_gambar.Name = "b_gambar";
            b_gambar.Size = new Size(126, 106);
            b_gambar.TabIndex = 0;
            b_gambar.UseVisualStyleBackColor = true;
            b_gambar.Click += b_gambar_Click;
            // 
            // Add_Traditional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Add_Traditional";
            Text = "Add_Traditional";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cb_category;
        private Button b_gambar;
        private TextBox tb_stock;
        private TextBox tb_asal;
        private TextBox tb_sewa;
        private TextBox tb_nama;
        private Button b_cancel;
        private Button b_save;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}
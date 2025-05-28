namespace KostumKita
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            tb_username = new TextBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            tb_Password = new TextBox();
            tb_email = new TextBox();
            button1 = new Button();
            dtp_Tanggal_Lahir = new DateTimePicker();
            pictureBox1 = new PictureBox();
            tb_ConfirmPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(147, 183);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(190, 23);
            tb_username.TabIndex = 1;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(147, 275);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(190, 23);
            tb_Password.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(377, 183);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(190, 23);
            tb_email.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(231, 314);
            button1.Name = "button1";
            button1.Size = new Size(239, 23);
            button1.TabIndex = 8;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dtp_Tanggal_Lahir
            // 
            dtp_Tanggal_Lahir.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_Tanggal_Lahir.Location = new Point(256, 230);
            dtp_Tanggal_Lahir.Name = "dtp_Tanggal_Lahir";
            dtp_Tanggal_Lahir.Size = new Size(190, 20);
            dtp_Tanggal_Lahir.TabIndex = 9;
            dtp_Tanggal_Lahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-6, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(737, 489);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Location = new Point(377, 273);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(190, 23);
            tb_ConfirmPassword.TabIndex = 11;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(tb_ConfirmPassword);
            Controls.Add(dtp_Tanggal_Lahir);
            Controls.Add(button1);
            Controls.Add(tb_email);
            Controls.Add(tb_Password);
            Controls.Add(tb_username);
            Controls.Add(pictureBox1);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_username;
        private Label label2;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Label label3;
        private Label label4;
        private TextBox tb_Password;
        private TextBox tb_email;
        private Button button1;
        private DateTimePicker dtp_Tanggal_Lahir;
        private PictureBox pictureBox1;
        private TextBox tb_ConfirmPassword;
    }
}

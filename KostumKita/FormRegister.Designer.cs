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
            tb_ConfirmPassword = new TextBox();
            panel1 = new Panel();
            b_ConfirmPassword = new Button();
            b_ShowPassword = new Button();
            b_Back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(311, 306);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(298, 23);
            tb_username.TabIndex = 1;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(311, 454);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(298, 23);
            tb_Password.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(711, 306);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(295, 23);
            tb_email.TabIndex = 7;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(440, 513);
            button1.Name = "button1";
            button1.Size = new Size(395, 37);
            button1.TabIndex = 8;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dtp_Tanggal_Lahir
            // 
            dtp_Tanggal_Lahir.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_Tanggal_Lahir.Location = new Point(485, 381);
            dtp_Tanggal_Lahir.Name = "dtp_Tanggal_Lahir";
            dtp_Tanggal_Lahir.Size = new Size(303, 20);
            dtp_Tanggal_Lahir.TabIndex = 9;
            dtp_Tanggal_Lahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Location = new Point(711, 452);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(295, 23);
            tb_ConfirmPassword.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(b_ConfirmPassword);
            panel1.Controls.Add(b_ShowPassword);
            panel1.Controls.Add(b_Back);
            panel1.Controls.Add(tb_username);
            panel1.Controls.Add(tb_email);
            panel1.Controls.Add(tb_Password);
            panel1.Controls.Add(tb_ConfirmPassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dtp_Tanggal_Lahir);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 12;
            // 
            // b_ConfirmPassword
            // 
            b_ConfirmPassword.BackgroundImage = Properties.Resources.Lock1;
            b_ConfirmPassword.BackgroundImageLayout = ImageLayout.Center;
            b_ConfirmPassword.Location = new Point(979, 448);
            b_ConfirmPassword.Name = "b_ConfirmPassword";
            b_ConfirmPassword.Size = new Size(30, 30);
            b_ConfirmPassword.TabIndex = 14;
            b_ConfirmPassword.UseVisualStyleBackColor = true;
            b_ConfirmPassword.Click += b_ConfirmPassword_Click;
            // 
            // b_ShowPassword
            // 
            b_ShowPassword.BackgroundImage = Properties.Resources.Lock1;
            b_ShowPassword.BackgroundImageLayout = ImageLayout.Center;
            b_ShowPassword.Location = new Point(580, 449);
            b_ShowPassword.Name = "b_ShowPassword";
            b_ShowPassword.Size = new Size(30, 32);
            b_ShowPassword.TabIndex = 13;
            b_ShowPassword.UseVisualStyleBackColor = true;
            b_ShowPassword.Click += b_ShowPassword_Click_1;
            // 
            // b_Back
            // 
            b_Back.BackColor = SystemColors.ButtonHighlight;
            b_Back.BackgroundImage = (Image)resources.GetObject("b_Back.BackgroundImage");
            b_Back.Location = new Point(12, 90);
            b_Back.Name = "b_Back";
            b_Back.Size = new Size(72, 72);
            b_Back.TabIndex = 12;
            b_Back.Text = "Back";
            b_Back.UseVisualStyleBackColor = false;
            b_Back.Click += b_Back_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private TextBox tb_ConfirmPassword;
        private Panel panel1;
        private Button b_Back;
        private Button b_ShowPassword;
        private Button b_ConfirmPassword;
    }
}

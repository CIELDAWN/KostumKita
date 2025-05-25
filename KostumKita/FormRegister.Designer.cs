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
            label1 = new Label();
            tb_username = new TextBox();
            label2 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            label3 = new Label();
            label4 = new Label();
            tb_Password = new TextBox();
            tb_email = new TextBox();
            button1 = new Button();
            dtp_Tanggal_Lahir = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 47);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(169, 65);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 125);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Tanggal Lahir";
            label2.Click += label2_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 47);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 125);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "password";
            label4.Click += label4_Click;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(367, 143);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(100, 23);
            tb_Password.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(367, 65);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(100, 23);
            tb_email.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(298, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dtp_Tanggal_Lahir
            // 
            dtp_Tanggal_Lahir.Location = new Point(115, 143);
            dtp_Tanggal_Lahir.Name = "dtp_Tanggal_Lahir";
            dtp_Tanggal_Lahir.Size = new Size(200, 23);
            dtp_Tanggal_Lahir.TabIndex = 9;
            dtp_Tanggal_Lahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtp_Tanggal_Lahir);
            Controls.Add(button1);
            Controls.Add(tb_email);
            Controls.Add(tb_Password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_username);
            Controls.Add(label1);
            Name = "Form_Register";
            Text = "FormRegister";
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
    }
}

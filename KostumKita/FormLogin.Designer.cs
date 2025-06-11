namespace KostumKita
{
    partial class FormLogin
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
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            b_ShowPassword = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_Username.Location = new Point(502, 337);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(336, 23);
            tb_Username.TabIndex = 1;
            tb_Username.TextChanged += tb_Username_TextChanged;
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_Password.Location = new Point(502, 407);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(336, 25);
            tb_Password.TabIndex = 3;
            tb_Password.TextChanged += tb_Password_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(481, 479);
            button1.Name = "button1";
            button1.Size = new Size(403, 39);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Maroon;
            linkLabel1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(722, 535);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 16);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Log_in_FIX3;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(b_ShowPassword);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tb_Password);
            panel1.Controls.Add(tb_Username);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // b_ShowPassword
            // 
            b_ShowPassword.BackgroundImage = Properties.Resources.Lock1;
            b_ShowPassword.BackgroundImageLayout = ImageLayout.Center;
            b_ShowPassword.Location = new Point(809, 408);
            b_ShowPassword.Name = "b_ShowPassword";
            b_ShowPassword.Size = new Size(29, 24);
            b_ShowPassword.TabIndex = 6;
            b_ShowPassword.UseVisualStyleBackColor = true;
            b_ShowPassword.Click += b_ShowPassword_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_Username;
        private TextBox tb_Password;
        private Button button1;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Button b_ShowPassword;
    }
}
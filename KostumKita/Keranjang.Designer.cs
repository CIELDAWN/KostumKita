namespace KostumKita
{
    partial class Keranjang
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
            Home3 = new Button();
            SuspendLayout();
            // 
            // Home3
            // 
            Home3.BackColor = Color.LightCoral;
            Home3.Font = new Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home3.ForeColor = Color.White;
            Home3.Location = new Point(25, 12);
            Home3.Name = "Home3";
            Home3.Size = new Size(104, 24);
            Home3.TabIndex = 0;
            Home3.Text = "HOME";
            Home3.UseVisualStyleBackColor = false;
            Home3.Click += Home3_Click;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(Home3);
            Name = "Keranjang";
            Text = "Keranjang";
            ResumeLayout(false);
        }

        #endregion

        private Button Home3;
    }
}
namespace KostumKita
{
    partial class Transaksi
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
            Home5 = new Button();
            SuspendLayout();
            // 
            // Home5
            // 
            Home5.BackColor = Color.LightCoral;
            Home5.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home5.ForeColor = Color.White;
            Home5.Location = new Point(12, 12);
            Home5.Name = "Home5";
            Home5.Size = new Size(112, 28);
            Home5.TabIndex = 0;
            Home5.Text = "HOME";
            Home5.UseVisualStyleBackColor = false;
            Home5.Click += Home5_Click;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(Home5);
            Name = "Transaksi";
            Text = "Transaksi";
            ResumeLayout(false);
        }

        #endregion

        private Button Home5;
    }
}
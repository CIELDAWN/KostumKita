namespace KostumKita
{
    partial class Live
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
            Home4 = new Button();
            SuspendLayout();
            // 
            // Home4
            // 
            Home4.BackColor = Color.LightCoral;
            Home4.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Home4.ForeColor = Color.White;
            Home4.Location = new Point(52, 35);
            Home4.Name = "Home4";
            Home4.Size = new Size(108, 32);
            Home4.TabIndex = 0;
            Home4.Text = "HOME";
            Home4.UseVisualStyleBackColor = false;
            Home4.Click += Home4_Click;
            // 
            // Live
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(Home4);
            Name = "Live";
            Text = "Live";
            ResumeLayout(false);
        }

        #endregion

        private Button Home4;
    }
}
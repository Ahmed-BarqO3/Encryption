using Encryption_Winform.Screens.Control;

namespace Encryption_Winform.Screens
{
    partial class frmHill
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
            ctrlBase1 = new ctrlBase();
            SuspendLayout();
            // 
            // ctrlBase1
            // 
            ctrlBase1.BackColor = Color.FromArgb(32, 32, 32);
            ctrlBase1.Dock = DockStyle.Fill;
            ctrlBase1.Location = new Point(0, 0);
            ctrlBase1.Name = "ctrlBase1";
            ctrlBase1.Size = new Size(901, 530);
            ctrlBase1.TabIndex = 0;
            ctrlBase1.Load += ctrlBase1_Load;
            // 
            // frmHill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 530);
            Controls.Add(ctrlBase1);
            Name = "frmHill";
            Text = "Hill Cipher";
            ResumeLayout(false);
        }

        #endregion

        private ctrlBase ctrlBase1;
    }
}
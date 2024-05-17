namespace Encryption_Winform.Screens
{
    partial class frmCaesar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtPlain = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox2 = new GroupBox();
            rdDecryption = new Guna.UI2.WinForms.Guna2RadioButton();
            rdEncryption = new Guna.UI2.WinForms.Guna2RadioButton();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlain
            // 
            txtPlain.BackColor = Color.FromArgb(60, 60, 60);
            txtPlain.BorderColor = Color.FromArgb(0, 55, 78);
            txtPlain.CustomizableEdges = customizableEdges9;
            txtPlain.DefaultText = "";
            txtPlain.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPlain.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPlain.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPlain.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPlain.FillColor = Color.FromArgb(32, 32, 32);
            txtPlain.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPlain.Font = new Font("Segoe UI", 9F);
            txtPlain.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPlain.Location = new Point(125, 74);
            txtPlain.Margin = new Padding(3, 4, 3, 4);
            txtPlain.Name = "txtPlain";
            txtPlain.PasswordChar = '\0';
            txtPlain.PlaceholderText = "";
            txtPlain.SelectedText = "";
            txtPlain.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPlain.Size = new Size(415, 32);
            txtPlain.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(255, 240, 255);
            guna2HtmlLabel1.Location = new Point(23, 74);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(93, 26);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Plain Text:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(255, 240, 255);
            guna2HtmlLabel2.Location = new Point(76, 145);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(40, 26);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Key:";
            // 
            // txtKey
            // 
            txtKey.BackColor = Color.FromArgb(60, 60, 60);
            txtKey.BorderColor = Color.FromArgb(0, 55, 78);
            txtKey.CustomizableEdges = customizableEdges11;
            txtKey.DefaultText = "";
            txtKey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtKey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtKey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtKey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtKey.FillColor = Color.FromArgb(32, 32, 32);
            txtKey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Font = new Font("Segoe UI", 9F);
            txtKey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKey.Location = new Point(125, 145);
            txtKey.Margin = new Padding(3, 4, 3, 4);
            txtKey.Name = "txtKey";
            txtKey.PasswordChar = '\0';
            txtKey.PlaceholderText = "";
            txtKey.SelectedText = "";
            txtKey.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtKey.Size = new Size(151, 32);
            txtKey.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(rdDecryption);
            groupBox2.Controls.Add(rdEncryption);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(255, 240, 255);
            groupBox2.Location = new Point(703, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 114);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mode";
            // 
            // rdDecryption
            // 
            rdDecryption.AutoSize = true;
            rdDecryption.CheckedState.BorderColor = Color.FromArgb(232, 22, 91);
            rdDecryption.CheckedState.BorderThickness = 0;
            rdDecryption.CheckedState.FillColor = Color.FromArgb(232, 22, 91);
            rdDecryption.CheckedState.InnerColor = Color.White;
            rdDecryption.CheckedState.InnerOffset = -3;
            rdDecryption.Location = new Point(18, 65);
            rdDecryption.Name = "rdDecryption";
            rdDecryption.Size = new Size(103, 24);
            rdDecryption.TabIndex = 11;
            rdDecryption.Text = "Decryption";
            rdDecryption.UncheckedState.BorderColor = Color.Silver;
            rdDecryption.UncheckedState.BorderThickness = 2;
            rdDecryption.UncheckedState.FillColor = Color.Transparent;
            rdDecryption.UncheckedState.InnerColor = Color.Transparent;
            rdDecryption.CheckedChanged += rdDecryption_CheckedChanged;
            // 
            // rdEncryption
            // 
            rdEncryption.AutoSize = true;
            rdEncryption.Checked = true;
            rdEncryption.CheckedState.BorderColor = Color.FromArgb(232, 22, 91);
            rdEncryption.CheckedState.BorderThickness = 0;
            rdEncryption.CheckedState.FillColor = Color.FromArgb(232, 22, 91);
            rdEncryption.CheckedState.InnerColor = Color.LightGray;
            rdEncryption.CheckedState.InnerOffset = -3;
            rdEncryption.Location = new Point(18, 35);
            rdEncryption.Name = "rdEncryption";
            rdEncryption.Size = new Size(100, 24);
            rdEncryption.TabIndex = 10;
            rdEncryption.Text = "Encryption";
            rdEncryption.UncheckedState.BorderColor = Color.Silver;
            rdEncryption.UncheckedState.BorderThickness = 2;
            rdEncryption.UncheckedState.FillColor = Color.Transparent;
            rdEncryption.UncheckedState.InnerColor = Color.Transparent;
            // 
            // frmCaesar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 530);
            Controls.Add(groupBox2);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtKey);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtPlain);
            Name = "frmCaesar";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtPlain;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2RadioButton rdDecryption;
        private Guna.UI2.WinForms.Guna2RadioButton rdEncryption;
    }
}
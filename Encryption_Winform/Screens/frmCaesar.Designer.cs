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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtSource = new Guna.UI2.WinForms.Guna2TextBox();
            lblSource = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox2 = new GroupBox();
            rdDecryption = new Guna.UI2.WinForms.Guna2RadioButton();
            rdEncryption = new Guna.UI2.WinForms.Guna2RadioButton();
            lblResult = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtResult = new Guna.UI2.WinForms.Guna2TextBox();
            btnRests = new Guna.UI2.WinForms.Guna2Button();
            btnTask = new Guna.UI2.WinForms.Guna2Button();
            ctrlBase1 = new Control.ctrlBase();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.BackColor = Color.FromArgb(60, 60, 60);
            txtSource.BorderColor = Color.FromArgb(0, 55, 78);
            txtSource.CustomizableEdges = customizableEdges1;
            txtSource.DefaultText = "";
            txtSource.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSource.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSource.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSource.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSource.FillColor = Color.FromArgb(32, 32, 32);
            txtSource.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSource.Font = new Font("Segoe UI", 9F);
            txtSource.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSource.Location = new Point(125, 74);
            txtSource.Margin = new Padding(3, 4, 3, 4);
            txtSource.Name = "txtSource";
            txtSource.PasswordChar = '\0';
            txtSource.PlaceholderText = "";
            txtSource.SelectedText = "";
            txtSource.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSource.Size = new Size(415, 32);
            txtSource.TabIndex = 1;
            // 
            // lblSource
            // 
            lblSource.BackColor = Color.Transparent;
            lblSource.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSource.ForeColor = Color.FromArgb(255, 240, 255);
            lblSource.Location = new Point(10, 74);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(93, 26);
            lblSource.TabIndex = 2;
            lblSource.Text = "Plain Text:";
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
            txtKey.CustomizableEdges = customizableEdges3;
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
            txtKey.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            rdDecryption.CheckedState.BorderColor = Color.FromArgb(151, 99, 125);
            rdDecryption.CheckedState.BorderThickness = 0;
            rdDecryption.CheckedState.FillColor = Color.FromArgb(151, 99, 125);
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
            // 
            // rdEncryption
            // 
            rdEncryption.AutoSize = true;
            rdEncryption.Checked = true;
            rdEncryption.CheckedState.BorderColor = Color.FromArgb(151, 99, 125);
            rdEncryption.CheckedState.BorderThickness = 0;
            rdEncryption.CheckedState.FillColor = Color.FromArgb(151, 99, 125);
            rdEncryption.CheckedState.InnerColor = Color.LightGray;
            rdEncryption.CheckedState.InnerOffset = -3;
            rdEncryption.Location = new Point(18, 35);
            rdEncryption.Name = "rdEncryption";
            rdEncryption.Size = new Size(100, 24);
            rdEncryption.TabIndex = 10;
            rdEncryption.TabStop = true;
            rdEncryption.Text = "Encryption";
            rdEncryption.UncheckedState.BorderColor = Color.Silver;
            rdEncryption.UncheckedState.BorderThickness = 2;
            rdEncryption.UncheckedState.FillColor = Color.Transparent;
            rdEncryption.UncheckedState.InnerColor = Color.Transparent;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(255, 240, 255);
            lblResult.Location = new Point(10, 376);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(106, 26);
            lblResult.TabIndex = 14;
            lblResult.Text = "Cipher Text:";
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(60, 60, 60);
            txtResult.BorderColor = Color.FromArgb(0, 55, 78);
            txtResult.CustomizableEdges = customizableEdges5;
            txtResult.DefaultText = "";
            txtResult.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtResult.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtResult.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtResult.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtResult.FillColor = Color.FromArgb(32, 32, 32);
            txtResult.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtResult.Font = new Font("Segoe UI", 9F);
            txtResult.ForeColor = Color.FromArgb(56, 118, 29);
            txtResult.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtResult.Location = new Point(125, 376);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.PasswordChar = '\0';
            txtResult.PlaceholderText = "";
            txtResult.ReadOnly = true;
            txtResult.SelectedText = "";
            txtResult.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtResult.Size = new Size(415, 32);
            txtResult.TabIndex = 13;
            // 
            // btnRests
            // 
            btnRests.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRests.Cursor = Cursors.Hand;
            btnRests.CustomizableEdges = customizableEdges7;
            btnRests.DisabledState.BorderColor = Color.DarkGray;
            btnRests.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRests.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRests.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRests.FillColor = Color.FromArgb(86, 10, 10);
            btnRests.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRests.ForeColor = Color.White;
            btnRests.HoverState.FillColor = Color.FromArgb(69, 129, 142);
            btnRests.Location = new Point(721, 199);
            btnRests.Name = "btnRests";
            btnRests.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRests.Size = new Size(168, 35);
            btnRests.TabIndex = 16;
            btnRests.Text = "Rest";
            // 
            // btnTask
            // 
            btnTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTask.Cursor = Cursors.Hand;
            btnTask.CustomizableEdges = customizableEdges9;
            btnTask.DisabledState.BorderColor = Color.DarkGray;
            btnTask.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTask.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTask.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTask.FillColor = Color.FromArgb(10, 46, 54);
            btnTask.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTask.ForeColor = Color.White;
            btnTask.HoverState.FillColor = Color.FromArgb(69, 129, 142);
            btnTask.Location = new Point(721, 476);
            btnTask.Name = "btnTask";
            btnTask.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnTask.Size = new Size(168, 35);
            btnTask.TabIndex = 15;
            btnTask.Text = "Encryption";
            // 
            // ctrlBase1
            // 
            ctrlBase1.BackColor = Color.FromArgb(32, 32, 32);
            ctrlBase1.Dock = DockStyle.Fill;
            ctrlBase1.Location = new Point(0, 0);
            ctrlBase1.Name = "ctrlBase1";
            ctrlBase1.Size = new Size(901, 530);
            ctrlBase1.TabIndex = 17;
            ctrlBase1.Load += ctrlBase1_Load;
            // 
            // frmCaesar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 530);
            Controls.Add(ctrlBase1);
            Controls.Add(btnRests);
            Controls.Add(btnTask);
            Controls.Add(lblResult);
            Controls.Add(txtResult);
            Controls.Add(groupBox2);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtKey);
            Controls.Add(lblSource);
            Controls.Add(txtSource);
            Name = "frmCaesar";
            Text = "Caesar";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2RadioButton rdDecryption;
        private Guna.UI2.WinForms.Guna2RadioButton rdEncryption;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResult;
        private Guna.UI2.WinForms.Guna2TextBox txtResult;
        private Guna.UI2.WinForms.Guna2Button btnRests;
        private Guna.UI2.WinForms.Guna2Button btnTask;
        private Control.ctrlBase ctrlBase1;
    }
}

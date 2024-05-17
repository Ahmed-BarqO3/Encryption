using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Winform.Screens
{
    public partial class ctrlBase : UserControl
    {

        public delegate string RequstAlgorithm(string text,string key);
        event RequstAlgorithm _OnAlgorithmPerform;

        RequstAlgorithm algorithm;
        public ctrlBase()
        {
            InitializeComponent();
            _OnAlgorithmPerform += CtrlBase__OnAlgorithmPerform;
        }

   
        private void rdEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdEncryption.Checked)
            {
                rdDecryption.Checked = true;
                return;
            }

            lblSource.Text = "Plain Text:";
            lblResult.Text = "Cipher Text:";
            btnTask.Text = "Encryption";

            txtSource.Clear();
            txtResult.Clear();
        }

        private void rdDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdDecryption.Checked)
            {
                rdEncryption.Checked = true;
                return;
            }

            lblSource.Text = "Cipher Text:";
            lblResult.Text = "Plain Text:";
            btnTask.Text = "Decryption";

            txtSource.Clear();
            txtResult.Clear();
        }

        void ValidatingtextBox(Guna2TextBox box)
        {
            if (String.IsNullOrWhiteSpace(box.Text))
            {
                errorProvider1.SetError(box, "This Field is Recuierd");
            }
            else
                errorProvider1.SetError(box, "");
        }

        void HandelKeyPress(Guna2TextBox sender, KeyPressEventArgs e)
        {
            if (!Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
                errorProvider1.SetError(sender, "Only uppercase letters are accepted");
            else
                errorProvider1.SetError(sender, "");
        }

        private void txtUpperCase_Validating(object sender, CancelEventArgs e)
        {
            ValidatingtextBox((Guna2TextBox)sender);
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandelKeyPress((Guna2TextBox)sender, e);
            e.Handled = !Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }
        //----------------------------------------------------------------------------------------

        private void btnRests_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtResult.Clear();
            txtSource.Clear();
        }
        public void SentAlogrithms(RequstAlgorithm encrypt, RequstAlgorithm decrypt)
        {
            if (rdEncryption.Checked)
                algorithm = encrypt;
            else if (rdDecryption.Checked)
                algorithm = decrypt;
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            if(_OnAlgorithmPerform is not null)
             txtResult.Text = _OnAlgorithmPerform.Invoke(txtSource.Text,txtKey.Text);
        }
        private string CtrlBase__OnAlgorithmPerform(string text, string key) => txtResult.Text = algorithm(text, key);
    }
}

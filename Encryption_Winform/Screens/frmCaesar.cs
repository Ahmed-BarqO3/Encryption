using Encryption_Winform.Algorithms;
using System.ComponentModel;
namespace Encryption_Winform.Screens
{
    public partial class frmCaesar : Base
    {
        delegate string RequstAlgorithmHandler(string text, int key);
        RequstAlgorithmHandler _algorithm;

        public frmCaesar()
        {
            InitializeComponent();
            _algorithm = Caesar.Encryption;
        }

        private void rdEncryption_CheckedChanged(object sender, EventArgs e)
        {
            lblSource.Text = "Plain Text:";
            lblResult.Text = "Cipher Text:";
            btnTask.Text = "Encryption";

            _algorithm = Caesar.Encryption;

            txtSource.Clear();
            txtResult.Clear();
        }
        private void rdDecryption_CheckedChanged(object sender, EventArgs e)
        {
            lblSource.Text = "Cipher Text:";
            lblResult.Text = "Plain Text:";
            btnTask.Text = "Decryption";

            _algorithm = Caesar.Decryption;

            txtSource.Clear();
            txtResult.Clear();
        }

        private void btnRests_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtResult.Clear();
            txtSource.Clear();
        }
        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
                errorProvider1.SetError(txtKey, "Only digits are accepted");
            else
                errorProvider1.SetError(txtKey, "");

            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSource.Text))
                errorProvider1.SetError(txtSource, "This Field is Recuierd");
            else
                errorProvider1.SetError(txtSource, "");
        }
        private void txtSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
                errorProvider1.SetError(txtSource, "Only uppercase letters are accepted");
            else
                errorProvider1.SetError(txtSource, "");

            e.Handled = !Char.IsUpper(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        //-----------------------------------------------------------------------------------------
        private void btnTask_Click(object sender, EventArgs e) =>
          txtResult.Text = _algorithm(txtSource.Text, int.Parse(txtKey.Text));
    }
}

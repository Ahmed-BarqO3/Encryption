using System.ComponentModel;
using Guna.UI2.WinForms;

namespace Encryption_Winform.Screens.Control
{
    public partial class ctrlBase : UserControl
    {

        public delegate string RequstAlgorithmHandler(string text,string key);
        event RequstAlgorithmHandler OnAlgorithmPerform;

        RequstAlgorithmHandler _encrypt;
        RequstAlgorithmHandler _decrypt;

        RequstAlgorithmHandler algorithm;
        public ctrlBase()
        {
            InitializeComponent();
        }
        
  
        private void txtUpperCase_Validating(object sender, CancelEventArgs e) =>
           ValidatingtextBox((Guna2TextBox)sender);
        void ValidatingtextBox(Guna2TextBox box)
        {
            if (String.IsNullOrWhiteSpace(box.Text))
                errorProvider1.SetError(box, "This Field is Recuierd");
            else
                errorProvider1.SetError(box, "");
        }
        void HandelKeyPress(Guna2TextBox sender, KeyPressEventArgs e)
        {
            if (!Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
                errorProvider1.SetError(sender, "Only uppercase letters are accepted");
            else
                errorProvider1.SetError(sender, "");

            if (e.KeyChar == (char)Keys.Enter)
                btnTask.PerformClick();
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandelKeyPress((Guna2TextBox)sender, e);
            e.Handled = !Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }

        private void rdEncryption_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = _encrypt;

            lblSource.Text = "Plain Text:";
            lblResult.Text = "Cipher Text:";
            btnTask.Text = "Encryption";

            txtSource.Clear();
            txtResult.Clear();
        }

        private void rdDecryption_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = _decrypt;
            lblSource.Text = "Cipher Text:";
            lblResult.Text = "Plain Text:";
            btnTask.Text = "Decryption";

            txtSource.Clear();
            txtResult.Clear();
        }
        //----------------------------------------------------------------------------------------

        private void btnRests_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtResult.Clear();
            txtSource.Clear();
        }
        public void SentAlogrithms(RequstAlgorithmHandler encrypt, RequstAlgorithmHandler decrypt)
        {
            _encrypt = encrypt;
            _decrypt = decrypt;

            algorithm = _encrypt;

            OnAlgorithmPerform = ReturnResult_OnAlgorithmPerform;
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            if(OnAlgorithmPerform is not null)
             txtResult.Text = OnAlgorithmPerform.Invoke(txtSource.Text,txtKey.Text);
        }
        private string ReturnResult_OnAlgorithmPerform(string text, string key) => txtResult.Text = algorithm(text, key);
    }
}

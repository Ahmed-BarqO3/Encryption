using System.ComponentModel;
using Guna.UI2.WinForms;

namespace Encryption_Winform.Screens.Control;

public partial class ctrlBase : UserControl
{
    Type TypKey;


    public delegate string RequstAlgorithmHandler(string text, string key);
    public delegate string RequstAlgorithmWithINTKeyHandler(string text, int key);


    RequstAlgorithmHandler _encrypt;
    RequstAlgorithmHandler _decrypt;

    RequstAlgorithmWithINTKeyHandler _encryptWithIntKey;
    RequstAlgorithmWithINTKeyHandler _decryptWithIntKey;


    RequstAlgorithmHandler algorithm;
    RequstAlgorithmWithINTKeyHandler algorithmWithIntKey;

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


    private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(TypKey == typeof(string))
        {
            HandelKeyPress((Guna2TextBox)sender, e);
            e.Handled = !Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }
        else
        {
            if (!char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
            {
                errorProvider1.SetError(txtKey, "Only numbers are accepted");
                e.Handled = !Char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
            }
            else
                errorProvider1.SetError(txtKey, "");
        }

    }

    private void rdEncryption_CheckedChanged(object sender, EventArgs e)
    {
        if (TypKey == typeof(string))
            algorithm = _encrypt;
        else
            algorithmWithIntKey = _encryptWithIntKey;

        lblSource.Text = "Plain Text:";
        lblResult.Text = "Cipher Text:";
        btnTask.Text = "Encryption";

        txtSource.Clear();
        txtResult.Clear();
    }

    private void rdDecryption_CheckedChanged(object sender, EventArgs e)
    {
        if (TypKey == typeof(string))
            algorithm = _decrypt;
        else
            algorithmWithIntKey = _decryptWithIntKey;

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
        TypKey = typeof(string);
        _encrypt = encrypt;
        _decrypt = decrypt;

        algorithm = _encrypt;
    }

    public void SentAlogrithms(RequstAlgorithmWithINTKeyHandler encrypt, RequstAlgorithmWithINTKeyHandler decrypt)
    {
        TypKey = typeof(int);

        _encryptWithIntKey = encrypt;
        _decryptWithIntKey = decrypt;

        algorithmWithIntKey = _encryptWithIntKey;
    }
    private void btnTask_Click(object sender, EventArgs e)
    {
        if (TypKey == typeof(string))
            txtResult.Text = algorithm.Invoke(txtSource.Text, txtKey.Text);

        else if (TypKey == typeof(int))
            txtResult.Text = algorithmWithIntKey.Invoke(txtSource.Text, int.Parse(txtKey.Text));
    }
}

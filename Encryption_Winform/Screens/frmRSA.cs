using System.ComponentModel;
using Encryption_Winform.Algorithms;
using Encryption_Winform.Common;
using Guna.UI2.WinForms;

namespace Encryption_Winform.Screens;
public partial class frmRSA : Base
{
    readonly Func<uint, uint, uint, string, string> _encrypt = RSA.Encryption;
    readonly Func<uint, uint, uint, string, string> _decrypt = RSA.Decrypt;


    Func<uint, uint, uint, string, string> _alogrithm;

    public frmRSA()
    {
        InitializeComponent();
        _alogrithm = _encrypt;
    }

    private void txtBox_Validating(object sender, CancelEventArgs e) =>
       ValidatingtextBox((Guna2TextBox)sender);
    void ValidatingtextBox(Guna2TextBox box)
    {
        if (String.IsNullOrWhiteSpace(box.Text))
            errorProvider1.SetError(box, "This Field is Recuierd");
        else
            errorProvider1.SetError(box, "");
    }

    private void rdDecryption_CheckedChanged(object sender, EventArgs e)
    {

        _alogrithm = _decrypt;

        lblSource.Text = "Cipher Text:";
        lblResult.Text = "Plain Text:";
        btnTask.Text = "Decryption";

        txtSource.Clear();
        txtResult.Clear();
    }

    private void rdEncryption_CheckedChanged(object sender, EventArgs e)
    {
        _alogrithm = _encrypt;

        lblSource.Text = "Plain Text:";
        lblResult.Text = "Cipher Text:";
        btnTask.Text = "Encryption";

        txtSource.Clear();
        txtResult.Clear();
    }

    private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
        {
            errorProvider1.SetError(txtKey, "Only numbers are accepted");
            e.Handled = !Char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }
        else
            errorProvider1.SetError(txtKey, "");


    }

    private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
        {
            errorProvider1.SetError(txtq, "Only numbers are accepted");
            e.Handled = !Char.IsDigit(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }
        else
            errorProvider1.SetError(txtKey, "");

    }


    private void txtq_Validating(object sender, CancelEventArgs e)
    {
        ValidatingtextBox((Guna2TextBox)sender);

        uint.TryParse(txtKey.Text, out uint p);
        uint.TryParse(txtq.Text, out uint q);

       
   

       if (!q.IsPrime())
            errorProvider1.SetError(txtq, "The Number should be prime");

        else if (q == p)
            errorProvider1.SetError(txtq, "The Number should be different from p");
        else
            errorProvider1.SetError(txtq, "");

    }

    private void txtp_Validating(object sender, CancelEventArgs e)
    {
        ValidatingtextBox((Guna2TextBox)sender);

        uint.TryParse(txtKey.Text, out uint p);
        uint.TryParse(txtq.Text, out uint q);


        
        if (!p.IsPrime())
            errorProvider1.SetError(txtKey, "The Number should be prime");

        else if (p == q)
            errorProvider1.SetError(txtKey, "The Number should be different from q");

        else
            errorProvider1.SetError(txtKey, "");

       
    }

    private void txtE_Validating(object sender, CancelEventArgs e)
    {
        ValidatingtextBox((Guna2TextBox)sender);

        var p = uint.Parse(txtKey.Text);
        var q = uint.Parse(txtq.Text);
        var on = (p - 1) * (q - 1);

        uint.TryParse(txte.Text, out uint _e);
        if (_e < 1 || _e > on)
        {
            errorProvider1.SetError(txte, "The number Should be between 1 and " + on);
        }
        else
            errorProvider1.SetError(txte, "");
    }


    private void txtSource_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar))
        {
            errorProvider1.SetError(txtSource, "Only uppercase letters are accepted");
            e.Handled = !Char.IsUpper(e.KeyChar) && !((char)Keys.Back == e.KeyChar);
        }
        else
            errorProvider1.SetError(txtSource, "");
    }

    //________________________________________________________________

    private void btnTask_Click(object sender, EventArgs e)
    {
        var p = uint.Parse(txtKey.Text);
        var q = uint.Parse(txtq.Text);
        var _e = uint.Parse(txte.Text);

        txtResult.Text = _alogrithm.Invoke(p, q, _e, txtSource.Text);
    }
    private void btnRests_Click(object sender, EventArgs e)
    {
        txtq.Clear();
        txtSource.Clear();
        txtKey.Clear();
        txte.Clear();
    }
}

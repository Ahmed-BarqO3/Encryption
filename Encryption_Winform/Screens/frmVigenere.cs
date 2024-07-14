using Encryption_Winform.Algorithms;
using Encryption_Winform.Common;
namespace Encryption_Winform.Screens;
public partial class frmVigenere : Base
{
    public frmVigenere()
    {
        InitializeComponent();
    }
    readonly ISecurity v = new Vigenere();

    private void ctrlBase1_Load(object sender, EventArgs e) =>

        ctrlBase1.SentAlogrithms(v.Encrypt, v.Decrypt);
}

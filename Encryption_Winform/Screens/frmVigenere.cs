using Encryption_Winform.Algorithms;
namespace Encryption_Winform.Screens;
public partial class frmVigenere : Base
{
    public frmVigenere()
    {
        InitializeComponent();
    }

    private void ctrlBase1_Load(object sender, EventArgs e) =>
        ctrlBase1.SentAlogrithms(Vigenere.Encryption, Vigenere.Decryption);
}

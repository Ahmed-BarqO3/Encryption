using Encryption_Winform.Algorithms;
namespace Encryption_Winform.Screens;
public partial class frmPlayfair : Base
{
    public frmPlayfair()
    {
        InitializeComponent();
    }

    private void ctrlBase1_Load(object sender, EventArgs e)
    {
        ctrlBase1.SentAlogrithms(Playfair.Encryption, Playfair.Decryption);
    }
}

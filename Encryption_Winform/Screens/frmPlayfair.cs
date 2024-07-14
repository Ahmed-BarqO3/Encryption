using Encryption_Winform.Algorithms;
using Encryption_Winform.Common;
namespace Encryption_Winform.Screens;
public partial class frmPlayfair : Base
{
    public frmPlayfair()
    {
        InitializeComponent();
    }

    readonly ISecurity p = new Playfair();

    private void ctrlBase1_Load(object sender, EventArgs e) =>

        ctrlBase1.SentAlogrithms(p.Encrypt, p.Decrypt);
}

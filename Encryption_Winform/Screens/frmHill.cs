using Encryption_Winform.Algorithms;
using Encryption_Winform.Common;
namespace Encryption_Winform.Screens;

public partial class frmHill : Base
{
    public frmHill() =>
        InitializeComponent();


    readonly ISecurity h = new Hill();

    private void ctrlBase1_Load(object sender, EventArgs e) =>


        ctrlBase1.SentAlogrithms(h.Encrypt, h.Decrypt);

}

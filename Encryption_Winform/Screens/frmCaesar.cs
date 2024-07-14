using Encryption_Winform.Algorithms;

namespace Encryption_Winform.Screens;
public partial class frmCaesar : Base
{
    public frmCaesar()
    {
        InitializeComponent();

    }

    private void ctrlBase1_Load(object sender, EventArgs e) =>
    
        ctrlBase1.SentAlogrithms(Caesar.Encryption,Caesar.Decryption);
    
}

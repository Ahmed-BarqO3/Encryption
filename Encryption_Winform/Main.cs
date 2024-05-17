using Encryption_Winform.Algorithms;
using Encryption_Winform.Screens;

namespace Encryption_Winform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            frmPlayfair frm = new frmPlayfair();
            frm.Show();
        }
    }
}

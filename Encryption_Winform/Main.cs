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
        void LoadForm(Form frm)
        {
            if(pnlFill.Controls.Count > 0)
                pnlFill.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlFill.Controls.Add(frm);
            frm.Show();
        } 
        
        private void btnCaesar_Click(object sender, EventArgs e)
        {
            LoadForm(new frmCaesar());
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPlayfair());   
        }
    }
}

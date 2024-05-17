using Encryption_Winform.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Winform.Screens
{
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
}

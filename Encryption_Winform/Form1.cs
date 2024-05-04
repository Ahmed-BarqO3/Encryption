using Encryption_Winform.Algorithms;

namespace Encryption_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Caesar.Decryption("CJOGF".ToUpper(), 2);
        }
    }
}

using System;
using System.Windows.Forms;
using WL;

namespace WordAddIn1
{
    public partial class conv : Form
    {
        private WDHelper gWDHelper;		//Classe de fonction WDHelper.DLL généré depuis WinDev.

        public conv()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gWDHelper = new WDHelper();
        }
    }
}
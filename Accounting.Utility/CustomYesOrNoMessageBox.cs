using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Utility
{
    public partial class CustomYesOrNoMessageBox : Form
    {
        public bool isYes = false;
        public string lblText;
        public CustomYesOrNoMessageBox()
        {
            InitializeComponent();
        }

        private void CustomYesOrNoMessageBox_Load(object sender, EventArgs e)
        {
            lbl.Text = lblText;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

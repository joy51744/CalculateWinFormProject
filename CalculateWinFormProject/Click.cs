using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateWinFormProject
{
    public partial class Click : Form
    {
        private int n;

        public Click()
        {
            InitializeComponent();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            n++;
            labelClick.Text = "您已經點擊了... " + n + " 下";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            n = 0;
            labelClick.Text = "您已經點擊了... " + n + " 下";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
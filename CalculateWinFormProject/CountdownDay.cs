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
    public partial class CountdownDay : Form
    {
        public CountdownDay()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end = DateTime.Now;

            TimeSpan ts = start.Subtract(end);
            double days = ts.Days + 1;

            labelMessage.Text = "還剩下 " + days.ToString() + "天";
        }

        private void 到計時ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Countdown main = new Countdown();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
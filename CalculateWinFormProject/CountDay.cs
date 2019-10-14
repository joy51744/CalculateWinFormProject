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
    public partial class CountDay : Form
    {
        public CountDay()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end = Convert.ToDateTime(dateTimePicker2.Value);

            TimeSpan ts = end.Subtract(start);
            double dayCount = ts.TotalDays;

            labelMessage.Text = "差距 " + dayCount.ToString() + " 天";
        }
    }
}
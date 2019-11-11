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

            try
            {
                if (start.Date < end.Date)
                {
                    labelMessage.Text = end.ToShortDateString() + " 已過去 " + dayCount.ToString("f0") + " 天";
                }
                else if (start.Date == end.Date)
                {
                    labelMessage.Text = "開始時間和結束時間相同";
                }
                else
                {
                    labelMessage.Text = "差距 " + dayCount.ToString("f0") + " 天";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void 倒數日2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountdownDay day = new CountdownDay();
            this.Visible = false;
            day.Show();
        }

        private void 倒計時ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Countdown countdown = new Countdown();
            this.Visible = false;
            countdown.Show();
        }
    }
}
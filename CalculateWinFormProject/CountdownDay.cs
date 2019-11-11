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
            double days = ts.TotalDays;

            try
            {
                if (start.Date < end.Date)
                {
                    label1.Text = "現在是 " + end.Year + " 年 " + end.Month + " 月 " + end.Day + " 日 ";
                    labelMessage.Text = start.ToShortDateString() + " 已經過去 " + days.ToString("f0") + " 天";
                }
                else if (start.Date == end.Date)
                {
                    label1.Text = "現在是 " + end.Year + " 年 " + end.Month + " 月 " + end.Day + " 日 ";
                    labelMessage.Text = "計算時間等於今日時間";
                }
                else
                {
                    label1.Text = "現在是 " + end.Year + " 年 " + end.Month + " 月 " + end.Day + " 日 ";
                    labelMessage.Text = "距離 " + start.ToShortDateString() + " 還剩下 " + days.ToString("f0") + " 天";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void 倒數日ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountDay day = new CountDay();
            this.Visible = false;
            day.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 倒計時ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Countdown main = new Countdown();
            this.Visible = false;
            main.Show();
        }
    }
}
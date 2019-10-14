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
    public partial class Countdown : Form
    {
        private int waitSecond = 60;

        public Countdown()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waitSecond == 0)
            {
                timer1.Stop();
                label1.Text = "已到時間";
            }
            else
            {
                waitSecond--;
                label1.Text = "還剩下... " + waitSecond + " 秒";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 倒數日ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountdownDay day = new CountdownDay();
            this.Visible = false;
            day.Show();
        }
    }
}
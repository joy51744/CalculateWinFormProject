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
    public partial class InterestAnnually : Form
    {
        public InterestAnnually()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal Principal, Rate, Interest, Total;
            int Years;
            float InterestRate;
            double annualRate;
            int Period = 0;

            try
            {
                Principal = decimal.Parse(textBoxPrincipal.Text);
                InterestRate = float.Parse(textBoxInterest.Text) / 100.0f;
                Years = int.Parse(textBoxYearsRate.Text);
            }
            catch
            {
                MessageBox.Show("輸入格式有誤,請重新輸入");
                return;
            }

            annualRate = InterestRate;
            Period = Years;
            Rate = Principal * (decimal)Math.Pow((1 + annualRate), (double)Period);
            Total = (decimal)Rate;
            Interest = Total - Principal;

            label1.Text = "您的存款訊息如下：" + "\r\n" + "\r\n" +
                string.Format("1.存款金額： {0:N0} 元" + "\r\n" + "\r\n" +
                              "2.年 利 率： {1} %" + "\r\n" + "\r\n" +
                              "3.存    期： {2} 年" + "\r\n" + "\r\n" +
                              "4.利    息： {4:N0} 元" + "\r\n" + "\r\n" +
                              "5.計算方式：  Annually" + "\r\n" + "\r\n" +
                              "6.結算金額： {3:F2} 元", Principal, InterestRate, Years, Total, Interest);

            buttonCalculate.Visible = false;
            textBoxInterest.Clear();
            textBoxPrincipal.Clear();
            textBoxYearsRate.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestDaily daily = new InterestDaily();
            this.Visible = false;
            daily.Show();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestMonthly monthly = new InterestMonthly();
            this.Visible = false;
            monthly.Show();
        }

        private void quarterlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestQuarterly quarterly = new InterestQuarterly();
            this.Visible = false;
            quarterly.Show();
        }

        private void semiAnnuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestSemiAnnually semiAnnually = new InterestSemiAnnually();
            this.Visible = false;
            semiAnnually.Show();
        }
    }
}
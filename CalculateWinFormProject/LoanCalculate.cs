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
    public partial class LoanCalculate : Form
    {
        public LoanCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            double Principal, interest, yearsRate;

            try
            {
                Principal = Convert.ToDouble(textBoxPrincipal.Text);
                interest = Convert.ToDouble(textBoxInterest.Text);
                yearsRate = Convert.ToDouble(textBoxRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("格式粗入有誤,請重新輸入");
                return;
            }

            double Monthly, monthRate, payment, total, paymentInterest;
            Monthly = yearsRate * 12;
            monthRate = interest / 12;
            payment = Principal * (monthRate / 100) / (1 - Math.Pow((1.0 + (monthRate / 100)), -Monthly));
            total = Monthly * payment;
            paymentInterest = total - Principal;

            textBoxResult.Text = "本金：$" + string.Format("{0:n}", Principal) + "\r\n" + Environment.NewLine +
                "月數：" + Monthly + "\r\n" + Environment.NewLine +
                "月利率：" + string.Format("{0:n}", monthRate) + "%" + "\r\n" + Environment.NewLine +
                "月付額：" + string.Format("{0:n}", payment) + "\r\n" + Environment.NewLine +
                "總共還款金額：$" + string.Format("{0:n}", total) + "\r\n" + Environment.NewLine +
                "還款利息：$" + string.Format("{0:n}", paymentInterest) + "\r\n" + Environment.NewLine +
                "---------------------------------------------------------------" + Environment.NewLine +
                "0月餘額：$" + string.Format("{0:n}", Principal) + Environment.NewLine;
            string t = textBoxResult.Text;
            int i;
            for (i = 1; i <= Monthly; i++)
            {
                Principal = Principal * (1 + (monthRate / 100)) - payment;
                t += i + "月餘額：$";
                t += string.Format("{0:n}", Principal);
                t += "\r\n";
            }
            textBoxResult.Text = t;
            buttonCalculate.Visible = false;
            textBoxPrincipal.Clear();
            textBoxRate.Clear();
            textBoxInterest.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
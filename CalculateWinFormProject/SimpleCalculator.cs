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
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOperand1.Clear();
            textBoxOperand2.Clear();
            textBoxOutput.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int opd1, opd2, op = 1;
            double result = 0.0;
            opd1 = Convert.ToInt32(textBoxOperand1.Text);
            opd2 = Convert.ToInt32(textBoxOperand2.Text);

            //取得運算子

            if (radioButtonPlus.Checked) op = 1;
            if (radioButtonSubtract.Checked) op = 2;
            if (radioButtonMultiply.Checked) op = 3;
            if (radioButtonDivide.Checked) op = 4;

            if (op == 1/*條件式 1*/)
            { //當條件式 1 为真時執行
                result = opd1 + opd2;
                textBoxOutput.Text = textBoxOperand1.Text + "+" + textBoxOperand2.Text + "=" + result.ToString();
            }
            else if (op == 2)
            { //當條件式 2 为真時執行
                result = opd1 - opd2;
                textBoxOutput.Text = textBoxOperand1.Text + "-" + textBoxOperand2.Text + "=" + result.ToString();
            }
            else if (op == 3)
            { //當條件式 3 为真時執行
                result = opd1 * opd2;
                textBoxOutput.Text = textBoxOperand1.Text + "*" + textBoxOperand2.Text + "=" + result.ToString();
            }
            else if (op == 4)
            { //當條件式 4 为真時執行
                result = opd1 / opd2;
                textBoxOutput.Text = textBoxOperand1.Text + "/" + textBoxOperand2.Text + "=" + result.ToString();
            }
            else
            {//當上面條件式都不為真時執行
                MessageBox.Show("錯誤，沒有選擇運算子！");
            }
        }
    }
}
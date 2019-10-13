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
    public partial class Calculator : Form
    {
        #region 類別

        private string operand1 = string.Empty;
        private string operand2 = string.Empty;

        private double result;
        private double opr1, opr2;

        private char operation;
        private string operation1;

        #endregion 類別

        public Calculator()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + button0.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = textBoxOperand.Text + buttonPoint.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation = '+';
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + buttonPlus.Text;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation = '-';
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + buttonSubtract.Text;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation = '*';
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + buttonMultiply.Text;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation = '/';
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + buttonDivide.Text;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation1 = "Mod";
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + "%";
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            operand1 = textBoxOperand.Text;
            operation1 = "Pow";
            textBoxOperand.Clear();
            textBoxResult.Text = operand1 + " " + "^";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double A = double.Parse(textBoxOperand.Text);
            textBoxOperand.Clear();

            try
            {
                if (textBoxOperand.Text != null)
                {
                    textBoxResult.Text = A + " 開根號 " + " = " + Math.Sqrt(A).ToString();
                }
                else
                {
                    textBoxResult.Text = "Error! Please enter the number.";
                }
            }
            catch
            {
                textBoxResult.Text = "Error! Pleasw enter the number.";
            }
        }

        private int factorial(int n)
        {
            if (n == 1) return 1;
            else return n * factorial(n - 1);
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOperand.Text != null)
                {
                    int n;
                    n = Convert.ToInt32(textBoxOperand.Text);
                    textBoxResult.Text = textBoxOperand.Text + " 的階乘為 " + factorial(n).ToString();
                }
                else
                {
                    textBoxResult.Text = "Error! Please enter the number.";
                }
            }
            catch
            {
                textBoxResult.Text = "Error! Please enter the number.";
            }
        }

        private void buttonPersent_Click(object sender, EventArgs e)
        {
            double A;
            A = Convert.ToDouble(textBoxOperand.Text) / Convert.ToDouble(100);
            textBoxOperand.Clear();
            textBoxOperand.Text = System.Convert.ToString(A);
        }

        private void button正負_Click(object sender, EventArgs e)
        {
            if (!textBoxOperand.Text.Contains("-"))
            {
                textBoxOperand.Text = "-" + textBoxOperand.Text;
            }
            else
            {
                textBoxOperand.Text = textBoxOperand.Text.Remove(0, 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOperand.Text != null)
                {
                    textBoxResult.Text = "1 " + " / " + textBoxOperand.Text + " = " + (1 / Convert.ToDouble(textBoxOperand.Text)).ToString();
                    textBoxOperand.Clear();
                }
                else
                {
                    textBoxResult.Text = "Error! Please enter the number.";
                }
            }
            catch
            {
                textBoxResult.Text = "Error! Please enter the number.";
            }
        }

        private void buttonPowTwo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOperand.Text != null)
                {
                    int number = Convert.ToInt32(textBoxOperand.Text);
                    textBoxOperand.Clear();
                    textBoxResult.Text = number + " 的平方 = " + Math.Pow(number, 2);
                }
                else
                {
                    textBoxResult.Text = "Error! Please enter the number.";
                }
            }
            catch
            {
                textBoxResult.Text = "Error! Please enter the number.";
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxOperand.Text.Length != 0)
                {
                    textBoxOperand.Text = textBoxOperand.Text.Substring(0, textBoxOperand.Text.Length - 1);
                }
                else
                {
                    textBoxResult.Text = "Error! No numbers need to be clear.";
                }
            }
            catch
            {
                textBoxResult.Text = "Error! No numbers need to be clear.";
            }
        }

        private void buttonClearError_Click(object sender, EventArgs e)
        {
            textBoxOperand.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOperand.Clear();
            textBoxResult.Clear();

            result = 0;
            opr1 = 0;
            opr2 = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                operand2 = textBoxOperand.Text;
                textBoxOperand.Clear();
                opr1 = double.Parse(operand1);
                opr2 = double.Parse(operand2);

                switch (operation)
                {
                    case '+':
                        result = opr1 + opr2;
                        textBoxResult.Text = operand1 + " + " + operand2 + " = " + result.ToString();
                        break;

                    case '-':
                        result = opr1 - opr2;
                        textBoxResult.Text = operand1 + " - " + operand2 + " = " + result.ToString();
                        break;

                    case '*':
                        if (opr2 != 0)
                        {
                            result = opr1 * opr2;
                            textBoxResult.Text = operand1 + " × " + operand2 + " = " + result.ToString();
                        }
                        else
                        {
                            textBoxResult.Text = "Error! Can't multiply by zero.";
                        }
                        break;

                    case '/':
                        if (opr2 != 0)
                        {
                            result = opr1 / opr2;
                            textBoxResult.Text = operand1 + " ÷ " + operand2 + " = " + result.ToString();
                        }
                        else
                        {
                            textBoxResult.Text = "Error! Can't multiply by zero.";
                        }
                        break;
                }

                switch (operation1)
                {
                    case "Mod":
                        if (opr2 != 0)
                        {
                            result = opr1 % opr2;
                            textBoxResult.Text = operand1 + " % " + operand2 + " = " + result.ToString();
                        }
                        else
                        {
                            textBoxResult.Text = "Error!Can't mod by zero.";
                        }
                        break;

                    case "Pow":
                        if (opr2 != 0)
                        {
                            result = Math.Pow(opr1, opr2);
                            textBoxResult.Text = operand1 + " ^ " + operand2 + " = " + result.ToString();
                        }
                        else
                        {
                            textBoxResult.Text = "Error!Can't pow by zero.";
                        }
                        break;
                }
            }
            catch
            {
            }
        }
    }
}
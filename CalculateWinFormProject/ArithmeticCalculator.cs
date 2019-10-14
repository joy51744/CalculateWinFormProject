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
    public partial class ArithmeticCalculator : Form
    {
        private string input = "";

        public ArithmeticCalculator()
        {
            InitializeComponent();
        }

        private void Input(char c)
        {
            input += c;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void ShowMessage()
        {
            textBoxOutput.Text = input;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Input('1');
            ShowMessage();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Input('2');
            ShowMessage();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Input('3');
            ShowMessage();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Input('4');
            ShowMessage();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Input('5');
            ShowMessage();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Input('6');
            ShowMessage();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Input('7');
            ShowMessage();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Input('8');
            ShowMessage();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Input('9');
            ShowMessage();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            Input('0');
            ShowMessage();
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            Input('.');
            ShowMessage();
        }

        private int GetSignpriority(char sign)
        {
            switch (sign)
            {
                case '+':
                case '-':
                    return 1;

                case '×':
                case '÷':
                    return 2;
            }
            return -1;
        }

        private int PostifixExpression(string obj)
        {
            if (obj == "+")
            {
                return '+';
            }
            else if (obj == "-")
            {
                return '-';
            }
            else if (obj == "×")
            {
                return '×';
            }
            else if (obj == "÷")
            {
                return '÷';
            }
            else
            {
                return '0';
            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            buttonEqual.Enabled = false;
            Stack<double> temStack = new Stack<double>();
            Queue<string> postifixExpressionQueue = new Queue<string>();
            Stack<char> SignStack = new Stack<char>();

            string tempString = "";
            int objType;
            double tempDouble;

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] <= '9' && input[i] >= '0' || input[i] == '.')
                    {
                        tempString += input[i];
                    }
                    else
                    {
                        if (tempString.Length > 0)
                        {
                            postifixExpressionQueue.Enqueue(tempString);
                            tempString = "";
                        }
                        if (SignStack.Count == 0)
                        {
                            SignStack.Push(input[i]);
                        }
                        else
                        {
                            #region 判斷式運算式優先級

                            if (GetSignpriority(input[i]) > GetSignpriority(SignStack.Peek()))
                            {
                                SignStack.Push(input[i]);
                            }
                            else
                            {
                                while (true)
                                {
                                    postifixExpressionQueue.Enqueue(Convert.ToString(SignStack.Pop()));
                                    if (SignStack.Count == 0 || GetSignpriority(input[i]) > GetSignpriority(SignStack.Peek()))
                                        break;
                                }
                                SignStack.Push(input[i]);
                            }

                            #endregion 判斷式運算式優先級
                        }
                    }
                }

                if (tempString.Length > 0)
                {
                    postifixExpressionQueue.Enqueue(tempString);
                    tempString = "";
                }
                while (SignStack.Count > 0)
                {
                    postifixExpressionQueue.Enqueue(Convert.ToString(SignStack.Pop()));
                }

                SignStack.Clear();
                tempString = "";

                while (postifixExpressionQueue.Count > 0)
                {
                    objType = PostifixExpression(postifixExpressionQueue.Peek());
                    switch (objType)
                    {
                        case '0':
                            temStack.Push(Convert.ToDouble(postifixExpressionQueue.Dequeue()));
                            break;

                        case '+':
                            postifixExpressionQueue.Dequeue();
                            temStack.Push(temStack.Pop() + temStack.Pop());
                            break;

                        case '-':
                            postifixExpressionQueue.Dequeue();
                            tempDouble = temStack.Pop();
                            temStack.Push(temStack.Pop() - tempDouble);
                            break;

                        case '×':
                            postifixExpressionQueue.Dequeue();
                            temStack.Push(temStack.Pop() * temStack.Pop());
                            break;

                        case '÷':
                            postifixExpressionQueue.Dequeue();
                            tempDouble = temStack.Pop();
                            if (tempDouble != 0)
                            {
                                temStack.Push(temStack.Pop() / tempDouble);
                            }
                            else
                            {
                                MessageBox.Show("Error!0不能為被除數");
                            }
                            break;

                        default:
                            MessageBox.Show("未知的錯誤!");
                            break;
                    }
                }

                input += "=" + Convert.ToString(temStack.Pop());

                ShowMessage();

                textBoxOutput.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的運算式！");
                throw;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            input = "";
            textBoxOutput.Clear();
            ShowMessage();
            textBoxOutput.ReadOnly = false;
            buttonEqual.Enabled = true;
        }

        private void ButtonClearError_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = string.Empty;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            try
            {
                if (input.Length != 0)
                {
                    textBoxOutput.Text = textBoxOutput.Text.Substring(0, textBoxOutput.Text.Length - 1);
                }
            }
            catch
            {
                MessageBox.Show("Error! Please No numbers need to clear.");
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Input('+');
            ShowMessage();
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            Input('-');
            ShowMessage();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            Input('×');
            ShowMessage();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Input('÷');
            ShowMessage();
        }
    }
}
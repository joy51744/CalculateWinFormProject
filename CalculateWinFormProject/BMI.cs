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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double bmi = 0.0;
            double height = 0.0;
            double weight = 0.0;
            try
            {
                height = double.Parse(textBoxHeight.Text);
            }
            catch
            {
                MessageBox.Show("請好好輸入身高");
                textBoxHeight.Text = string.Empty;
                textBoxHeight.Focus();
                return;
            }

            try
            {
                weight = double.Parse(textBoxWeight.Text);
            }
            catch
            {
                MessageBox.Show("請好好輸入體重");
                textBoxWeight.Text = string.Empty;
                textBoxWeight.Focus();
                return;
            }
            height = height / 100.0;
            bmi = weight / (height * height);
            MessageBox.Show(string.Format("BMI: {0}", bmi.ToString("#.##")));
        }

        private void 體重計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Weight weight = new Weight();
            this.Visible = false;
            weight.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
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
    public partial class Weight : Form
    {
        public Weight()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int height;
            double weight;

            try
            {
                height = Convert.ToInt32(textBoxHeight.Text);
            }
            catch
            {
                MessageBox.Show("請好好輸入身高");
                textBoxHeight.Text = string.Empty;
                textBoxHeight.Focus();
                return;
            }

            if (radioButtonBoy.Checked == true)
            {
                weight = (height - 80) * 0.7;
            }
            else
            {
                weight = (height - 70) * 0.6;
            }
            labelMessage.Text = weight.ToString("f1") + " Kg";
        }

        private void bMI計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            this.Visible = false;
            bmi.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
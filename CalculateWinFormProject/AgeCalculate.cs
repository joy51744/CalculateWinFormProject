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
    public partial class AgeCalculate : Form
    {
        public AgeCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePickerDOB.Value;
            DateTime now = System.DateTime.Now;
            TimeSpan ts = now - birthday;
            DateTime age = DateTime.MinValue.AddDays(ts.Days);

            try
            {
                if (now < birthday)
                {
                    MessageBox.Show("Current Date must be greater than Birthday Date.");
                    dateTimePickerDOB.Focus();
                }
                textBoxOutput.Text = string.Format("Your Age is:" + "\r\n" + "{0} Years {1} Months {2} Days", age.Year - 1, age.Month - 1, age.Day - 1);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
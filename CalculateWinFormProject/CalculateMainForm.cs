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
    public partial class CalculateMainForm : Form
    {
        public CalculateMainForm()
        {
            InitializeComponent();
        }

        private void buttonCilck_Click(object sender, EventArgs e)
        {
            Click click = new Click();
            this.Visible = false;
            click.Show();
        }

        private void buttonBMI_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            this.Visible = false;
            bmi.Show();
        }

        private void buttonSimple_Click(object sender, EventArgs e)
        {
            SimpleCalculator simple = new SimpleCalculator();
            this.Visible = false;
            simple.Show();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            this.Visible = false;
            calculator.Show();
        }

        private void buttonArithmeticCalculator_Click(object sender, EventArgs e)
        {
            ArithmeticCalculator calculator = new ArithmeticCalculator();
            this.Visible = false;
            calculator.Show();
        }

        private void buttonDiscountCalculator_Click(object sender, EventArgs e)
        {
            DiscountCalculator discount = new DiscountCalculator();
            this.Visible = false;
            discount.Show();
        }

        private void buttonPostageCalculate_Click(object sender, EventArgs e)
        {
            PostageCalculate postage = new PostageCalculate();
            this.Visible = false;
            postage.Show();
        }

        private void buttonInterestCalculate_Click(object sender, EventArgs e)
        {
            InterestCalculate interest = new InterestCalculate();
            this.Visible = false;
            interest.Show();
        }

        private void buttonLoanCalculate_Click(object sender, EventArgs e)
        {
            LoanCalculate loan = new LoanCalculate();
            this.Visible = false;
            loan.Show();
        }

        private void buttonAgeCalculate_Click(object sender, EventArgs e)
        {
            AgeCalculate age = new AgeCalculate();
            this.Visible = false;
            age.Show();
        }

        private void buttonCountdownDay_Click(object sender, EventArgs e)
        {
            CountdownDay day = new CountdownDay();
            this.Visible = false;
            day.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonCountDay_Click(object sender, EventArgs e)
        {
            CountDay count = new CountDay();
            this.Visible = false;
            count.Show();
        }
    }
}
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
    public partial class InterestCalculate : Form
    {
        public InterestCalculate()
        {
            InitializeComponent();
        }

        private void annuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestAnnually annually = new InterestAnnually();
            this.Visible = false;
            annually.Show();
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
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ClassWinFormProject.exe");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ControlWinFormProject.exe");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GameWinFormProject.exe");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ToolWinFormProject.exe");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ManagementSystemWinFormProject.exe");
        }
    }
}
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
            ClassWinFormProject.ClassMainForm main = new ClassWinFormProject.ClassMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ControlWinFormProject.ControlMainForm main = new ControlWinFormProject.ControlMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GameWinFormProject.GameMainForm main = new GameWinFormProject.GameMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ToolWinFormProject.ToolMainForm main = new ToolWinFormProject.ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ManagementSystemWinFormProject.ManagementSystemMainForm main = new ManagementSystemWinFormProject.ManagementSystemMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
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
    public partial class ZodiacCalculate : Form
    {
        public ZodiacCalculate()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int old = DateTime.Now.Year - dateTimePicker1.Value.Year;
            textBox1.Text = getZodiac(dateTimePicker1.Value);
            textBox2.Text = GetAtomFromBirthday(dateTimePicker1.Value);
        }

        private string GetAtomFromBirthday(DateTime birthday)
        {
            float birthdayF = 0.00F;

            if (birthday.Month == 1 && birthday.Day < 20)
            {
                birthdayF = float.Parse(string.Format("13.{0}", birthday.Day));
            }
            else
            {
                birthdayF = float.Parse(string.Format("{0}.{1}", birthday.Month, birthday.Day));
            }
            float[] atomBound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 13.20F };
            string[] atoms = { "水瓶座", "雙魚座", "白羊座", "金牛座", "雙子坐", "巨蟹座", "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "魔羯座" };

            string ret = "請輸入正確月份";
            for (int i = 0; i < atomBound.Length - 1; i++)
            {
                if (atomBound[i] <= birthdayF && atomBound[i + 1] > birthdayF)
                {
                    ret = atoms[i];
                    break;
                }
            }
            return ret;
        }

        private string getZodiac(DateTime birthday)
        {
            System.Globalization.ChineseLunisolarCalendar chinseCaleander = new System.Globalization.ChineseLunisolarCalendar();

            string TreeYear = "鼠牛虎兔龍蛇馬羊猴雞狗豬";

            int intYear = chinseCaleander.GetSexagenaryYear(birthday);

            string Tree = TreeYear.Substring(chinseCaleander.GetTerrestrialBranch(intYear) - 1, 1);

            return Tree;
        }
    }
}
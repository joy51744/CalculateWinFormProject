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
    public partial class PostageCalculate : Form
    {
        public PostageCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalcuate_Click(object sender, EventArgs e)
        {
            int g, q;

            try
            {
                g = int.Parse(textBoxKg.Text);
                q = int.Parse(textBoxQuantity.Text);
            }
            catch
            {
                MessageBox.Show("請重新輸入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇寄送種類", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (System.Convert.ToInt16(textBoxKg.Text) < 20)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "8" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 8 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "15" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 15 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "28" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 28 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "35" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 35 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "43" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 43 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "50" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 50 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 21 & System.Convert.ToInt16(textBoxKg.Text) <= 50)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "16" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 16 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "23" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 23 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "36" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 36 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "43" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 43 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "51" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 51 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "58" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 58 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 51 & System.Convert.ToInt16(textBoxKg.Text) <= 100)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "24" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 24 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "31" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 31 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "46" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 46 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "51" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 51 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "59" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 59 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "66" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 66 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 101 & System.Convert.ToInt16(textBoxKg.Text) <= 250)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "40" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 40 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "47" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 47 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "60" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 60 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "67" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 67 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "75" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 75 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "82" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 82 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 251 & System.Convert.ToInt16(textBoxKg.Text) <= 500)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "72" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 72 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "79" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 79 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "92" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 92 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "99" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 99 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "107" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 107 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "114" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 114 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 501 & System.Convert.ToInt16(textBoxKg.Text) <= 1000)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "112" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 112 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "119" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 119 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "132" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 132 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "139" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 139 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "147" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 147 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "154" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 154 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKg.Text) >= 1001 & System.Convert.ToInt16(textBoxKg.Text) <= 2000)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                            "包裹郵資:" + "160" + "元" + "\r\n" + "\r\n" +
                            "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "總共:" + 160 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "167" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 167 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "180" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 180 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "187" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 187 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "195" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 195 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelMessage.Text = "包裹公斤數:" + textBoxKg.Text + "kg" + "\r\n" + "\r\n" +
                         "包裹郵資:" + "202" + "元" + "\r\n" + "\r\n" +
                         "包裹數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                         "總共:" + 202 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else
            {
                labelMessage.Text = "您輸入的公克數不得超過200公克！";
                textBoxKg.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxKg.Text = "";
            textBoxQuantity.Text = "";
            labelMessage.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}
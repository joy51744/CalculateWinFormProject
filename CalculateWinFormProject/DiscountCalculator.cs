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
    public partial class DiscountCalculator : Form
    {
        public DiscountCalculator()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            CalculateMainForm main = new CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int q;

            try
            {
                q = int.Parse(textBoxQuantity.Text);
            }
            catch
            {
                MessageBox.Show("請重新輸入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇產品種類", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (System.Convert.ToInt16(textBoxQuantity.Text) < 10)
            {
                switch (comboBoxProduct.SelectedItem.ToString())
                {
                    case "蘋果盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "芭樂盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "鳳梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 130 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 130 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "水梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "西瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 180 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 180 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "蓮霧盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "葡萄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 150 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 150 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "柳丁盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 110 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 110 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "番茄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q + "元" + "\r\n" + "\r\n";
                        break;

                    case "木瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "沒有折扣" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxQuantity.Text) >= 10 & System.Convert.ToInt16(textBoxQuantity.Text) <= 20)
            {
                switch (comboBoxProduct.SelectedItem.ToString())
                {
                    case "蘋果盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "芭樂盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "鳳梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 130 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 130 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "水梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "西瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 180 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 180 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "蓮霧盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "葡萄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 150 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 150 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "柳丁盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 110 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 110 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "番茄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;

                    case "木瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "9折" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q * 0.9 + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxQuantity.Text) >= 20 & System.Convert.ToInt16(textBoxQuantity.Text) <= 30)
            {
                switch (comboBoxProduct.SelectedItem.ToString())
                {
                    case "蘋果盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "芭樂盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "鳳梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 130 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 130 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "水梨盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "西瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 180 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 180 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "蓮霧盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "葡萄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 150 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 150 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "柳丁盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 110 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 110 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "番茄盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 100 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 100 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;

                    case "木瓜盒":
                        labelMessage.Text = "產品:" + comboBoxProduct.Text + "\r\n" + "\r\n" +
                            "數量:" + string.Format("{0}", q) + "份" + "\r\n" + "\r\n" +
                            "金額:" + 120 + "元" + "\r\n" + "\r\n" +
                            "折扣:" + "8折" + "\r\n" + "\r\n" +
                            "總計:" + 120 * q * 0.8 + "元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else
            {
                labelMessage.Text = "您一次不得購買30份以上！";
                textBoxQuantity.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxQuantity.Clear();
            comboBoxProduct.SelectedIndex = -1;
            labelMessage.Text = "";
        }
    }
}
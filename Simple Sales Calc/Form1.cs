using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC670_Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double productOne, productTwo, productThree;
        private static double p1Quan, p2Quan, p3Quan;
        private static double p1Sales, p2Sales, p3Sales, highestSale;
        private static int highestSwitch;

        public static double Max(double x, double y, double z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        private void calc_Click(object sender, EventArgs e)
        {
            productOne = 2.98;
            productTwo = 4.5;
            productThree = 9.98;

            try
            {
                if (productOneTextBox.Text != null)
                {
                    p1Quan = Convert.ToDouble(productOneTextBox.Text);
                    p1Sales = productOne * p1Quan;
                }
                if (productTwoTextBox.Text != null)
                {
                    p2Quan = Convert.ToDouble(productTwoTextBox.Text);
                    p2Sales = productTwo * p2Quan;
                }
                if (productOneTextBox.Text != null)
                {
                    p3Quan = Convert.ToDouble(productThreeTextBox.Text);
                    p3Sales = productThree * p3Quan;
                }
                
            }
            catch (Exception) 
            {
                MessageBox.Show("Please enter numerical values", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                p1Sales = 0;
                p2Sales = 0;
                p3Sales = 0;
            }

            prod1SaleInfo.Text = p1Sales.ToString("c");
            prod2SaleInfo.Text = p2Sales.ToString("c");
            prod3SaleInfo.Text = p3Sales.ToString("c");

            highestSale = Max(p1Sales, p2Sales, p3Sales);
            if (highestSale == p1Sales)
            {
                highestSwitch = 1;
            }
            else if (highestSale == p2Sales)
            {
                highestSwitch = 2;
            }
            else
            {
                highestSwitch = 3;
            }

            switch (highestSwitch)
            {
                case 1:
                    highestQuanSaleInfo.Text = String.Format("Product 1 with {0}", p1Quan);
                    break;
                case 2: 
                    highestQuanSaleInfo.Text = String.Format("Product 2 with {0}", p2Quan);
                    break;
                case 3:
                    highestQuanSaleInfo.Text = String.Format("Product 3 with {0}", p3Quan);
                    break;
                default:
                    highestQuanSaleInfo.Text = "Default";
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            p1Quan = 0;
            p2Quan = 0;
            p3Quan = 0;

            productOneTextBox.Clear();
            productTwoTextBox.Clear();
            productThreeTextBox.Clear();

            prod1SaleInfo.Text = "";
            prod2SaleInfo.Text = "";
            prod3SaleInfo.Text = "";
            highestQuanSaleInfo.Text = "";
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

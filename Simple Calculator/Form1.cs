using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC670_HW1__GUI
{
    public partial class Form1 : Form
    {
        public static double num1;
        public static double num2;
        public static double result; 

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1TextBox.Text);
            num2 = Convert.ToDouble(num2TextBox.Text);

            result = num1 + num2; 

            resultLabel.Text = "";
            resultLabel.Text = "Sum";

            label1.Text = Convert.ToString(result);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1TextBox.Text);
            num2 = Convert.ToDouble(num2TextBox.Text);

            result = num1 - num2;

            resultLabel.Text = "";
            resultLabel.Text = "Difference";

            label1.Text = Convert.ToString(result);
        }

        private void mult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1TextBox.Text);
            num2 = Convert.ToDouble(num2TextBox.Text);

            result = num1 * num2;

            resultLabel.Text = "";
            resultLabel.Text = "Product";

            label1.Text = Convert.ToString(result);
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(num1TextBox.Text);
            num2 = Convert.ToDouble(num2TextBox.Text);

            if (num2 == 0)
            {
                label1.Text = "Undefined";
                MessageBox.Show("Danger Will Robinson, division by 0 results in an undefined number");
            }
            else
            {
                result = num1 / num2;
            }

            resultLabel.Text = "";
            resultLabel.Text = "Quotient";

            label1.Text = Convert.ToString(result);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;

            num1TextBox.Text = "";
            num2TextBox.Text = "";
            label1.Text = "";

            resultLabel.Text = "";
            resultLabel.Text = "Result";
        }
    }
}

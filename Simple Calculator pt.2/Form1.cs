using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC670_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNum, secondNum;
        double result;

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNumTextBox.Text != null)
                {
                    firstNum = Convert.ToDouble(firstNumTextBox.Text);
                }

                if (secondNumTextBox.Text != null)
                {
                    secondNum = Convert.ToDouble(secondNumTextBox.Text);
                }

                result = firstNum + secondNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numerical values", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            answerLabel.Text = String.Format("The sum of {0} and {1} is {2}", 
                                firstNum, secondNum, result);
        }

        private void diff_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNumTextBox.Text != null)
                {
                    firstNum = Convert.ToDouble(firstNumTextBox.Text);
                }

                if (secondNumTextBox.Text != null)
                {
                    secondNum = Convert.ToDouble(secondNumTextBox.Text);
                }

                result = firstNum - secondNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numerical values", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            answerLabel.Text = String.Format("The difference of {0} and {1} is {2}", 
                                firstNum, secondNum, result);
        }

        private void prod_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNumTextBox.Text != null)
                {
                    firstNum = Convert.ToDouble(firstNumTextBox.Text);
                }

                if (secondNumTextBox.Text != null)
                {
                    secondNum = Convert.ToDouble(secondNumTextBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numerical values", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstNum * secondNum;

            answerLabel.Text = String.Format("The product of {0} and {1} is {2}", 
                                firstNum, secondNum, result);
        }

        private void quot_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNumTextBox.Text != null)
                {
                    firstNum = Convert.ToDouble(firstNumTextBox.Text);
                }
                
                if (secondNumTextBox.Text != null)
                {
                    secondNum = Convert.ToDouble(secondNumTextBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numerical values", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (secondNum > 0)
                {
                    result = firstNum / secondNum;

                    answerLabel.Text = String.Format("The quotient of {0} and {1} is {2}",
                                        firstNum, secondNum, result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a non-zero value for the second number", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            firstNumTextBox.Clear();
            secondNumTextBox.Clear();
            answerLabel.Text = "";
            result = 0;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

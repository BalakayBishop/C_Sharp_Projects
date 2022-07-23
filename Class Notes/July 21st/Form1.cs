using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace July21st_GUIClassNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yellow");
            // use insert for specific index 
            // listBox1.Items.Insert(1, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // to delete items 
            listBox1.Items.Remove("Black"); // specific item to be removed 
            listBox1.Items.RemoveAt(1); // remove items from the specific index
        }
    }
}

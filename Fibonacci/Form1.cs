using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1 =0;
        double number2 =1;
        private void button1_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < 30; i++)
            {
                textBox1.Text = textBox1.Text + number1.ToString()+ " ";
                number1 = number1 + number2;
                textBox1.Text = textBox1.Text + number2.ToString() + " ";
                number2 = number2 + number1;
            }
        }
    }
}

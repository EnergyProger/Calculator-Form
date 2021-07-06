using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Forms
{
    public partial class Form1 : Form
    {
        private string Action;
        private string Number;
        private bool Number2;
        private Operations operation;

        public Form1()
        {
            operation = new Operations();
            Number2 = false;
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Number2)
            {
                Number2 = false;
                textBox1.Text = "0";
            }

            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text += B.Text;
            }
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Action = B.Text;

            Number = textBox1.Text;
            Number2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2;
            double result = 0;

            dn1 = Convert.ToDouble(Number);
            dn2 = Convert.ToDouble(textBox1.Text);

            if(Action == "+")
            {
                result = operation.Sum(dn1, dn2);
            }
            else if (Action == "-")
            {
                result = operation.Min(dn1, dn2);
            }
            else if (Action == "x")
            {
                result = operation.Mul(dn1, dn2);
            }
            else if (Action == "/")
            {
                result = operation.Del(dn1, dn2);
            }
            else if (Action == "%")
            {
                result = operation.Percent(dn1, dn2);
            }

            Action = "=";
            Number2 = true;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(textBox1.Text);

            textBox1.Text = operation.Sqrt(dn).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(textBox1.Text);

            textBox1.Text = operation.Pow(dn).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(textBox1.Text);
            double result = operation.OneDelNum(dn);

            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(textBox1.Text);
            double result = operation.PlusMin(dn);

            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length-1);
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}

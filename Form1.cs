using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        Double result;
        String operation = "";
        bool operated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operated)
            {
                textBox1.Clear();
            }

            operated = false;

            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(result != 0)
            {
                buttonequal.PerformClick();
                operation = button.Text;
                preview.Text = result + " " + operation;

                operated = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBox1.Text);
                preview.Text = result + " " + operation;

                operated = true;
            }
        }

        private void ButtonclearEntryClick(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void ButtonEqualClick(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            preview.Text = "";
        }

        private void ButtonSignClick(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();
        }
    }
}

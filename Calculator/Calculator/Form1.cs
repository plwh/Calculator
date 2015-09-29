using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{

    public partial class Form1 : Form
    {
        string input = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        char operation;
        double result = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.firstOperand = string.Empty;
            this.secondOperand = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '/';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '*';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '+';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '-';
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            secondOperand = input;
            double firstNumber, secondNumber;
            double.TryParse(firstOperand, NumberStyles.Any, CultureInfo.InvariantCulture, out firstNumber);
            double.TryParse(secondOperand, NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber);

            if(operation == '/')
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "You cannot divide by zero!";
                }
            }
            else if (operation == '*')
            {
                result = firstNumber * secondNumber;
                textBox1.Text = result.ToString();
            }
            else if (operation == '+')
            {
                result = firstNumber + secondNumber;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
                textBox1.Text = result.ToString();
            }
        }
    }
}

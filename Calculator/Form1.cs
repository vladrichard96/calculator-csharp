using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool power;
        double result, left, right;
        char oper;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "ON";
            result = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ON") 
            {
                power = true;
                button1.Text = "OFF";
                textBox1.Text = Convert.ToString(result);
            }
            else 
            {
                power = false;
                result = 0;
                button1.Text = "ON";
                textBox1.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = Convert.ToString(result);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (power) 
            { 
            result = Math.Sqrt(Convert.ToDouble(textBox1.Text.Replace('.', ',')));
            int s = Convert.ToString(Math.Truncate(result)).Length;
            string str = Math.Round(result, 10 - s).ToString();
            textBox1.Text = str.Replace(',','.');
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button5.Text;
                else textBox1.Text = button5.Text;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button6.Text;
                else textBox1.Text = button6.Text;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button7.Text;
                else textBox1.Text = button7.Text;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (power)
            {
                oper = '/';
                if (left == 0)
                {
                    left = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    textBox1.Text = "0";
                }
                else
                {
                    right = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    left = left / right;
                    textBox1.Text = "0";
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button9.Text;
                else textBox1.Text = button9.Text;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button10.Text;
                else textBox1.Text = button10.Text;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button11.Text;
                else textBox1.Text = button11.Text;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (power)
            {
                oper = '*';
                if (left == 0)
                {
                    left = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    textBox1.Text = "0";
                }
                else
                {
                    right = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    left = left * right;
                    textBox1.Text = "0";
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                textBox1.Text = textBox1.Text + button13.Text;
                else textBox1.Text = button13.Text;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button14.Text;
                else textBox1.Text = button14.Text;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button15.Text;
                else textBox1.Text = button15.Text;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (power)
            {
                oper = '-';
                if (left == 0)
                {
                    left = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    textBox1.Text = "0";
                }
                else
                {
                    right = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    left = left - right;
                    textBox1.Text = "0";
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text != "0")
                    textBox1.Text = textBox1.Text + button17.Text;
                else textBox1.Text = button17.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (power)
            {
                switch (oper)
                {
                    case '+':
                        {
                            result = left + (left*Convert.ToDouble(textBox1.Text.Replace('.', ','))/100);
                            textBox1.Text = Convert.ToString(result).Replace(',', '.');
                            left = 0; right = 0;
                            break;
                        }
                    case '-':
                        {
                            result = left - (left * Convert.ToDouble(textBox1.Text.Replace('.', ',')) / 100);
                            textBox1.Text = Convert.ToString(result).Replace(',', '.');
                            left = 0; right = 0;
                            break;
                        }
                    case '*':
                        {
                            result = left * Convert.ToDouble(textBox1.Text.Replace('.', ',')) / 100;
                            int s = Convert.ToString(Math.Truncate(result)).Length;
                            string str = Math.Round(result, 10 - s).ToString();
                            textBox1.Text = Convert.ToString(str).Replace(',', '.');
                            left = 0; right = 0;
                            break;
                        }
                    case '/':
                        {
                            result = left / (left * Convert.ToDouble(textBox1.Text.Replace('.', ',')) / 100);
                            int s = Convert.ToString(Math.Truncate(result)).Length;
                            string str = Math.Round(result, 10 - s).ToString();
                            textBox1.Text = Convert.ToString(str).Replace(',', '.');
                            left = 0; right = 0;
                            break;
                        }
                    default: break;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (power && textBox1.Text.Length < 11)
            {
                if (textBox1.Text.Length >= 1 && !textBox1.Text.Contains(".")) textBox1.Text = textBox1.Text + button18.Text;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (power)
            {
                switch (oper)
                {
                    case '+':
                    {
                        result = left + Convert.ToDouble(textBox1.Text.Replace('.', ','));
                        textBox1.Text = Convert.ToString(result).Replace(',', '.');
                        left = 0; right = 0;
                        break;
                    }
                    case '-':
                    {
                        result = left - Convert.ToDouble(textBox1.Text.Replace('.', ','));
                        textBox1.Text = Convert.ToString(result).Replace(',', '.');
                        left = 0; right = 0;
                        break;
                    }
                    case '*':
                    {
                        result = left * Convert.ToDouble(textBox1.Text.Replace('.', ','));
                        int s = Convert.ToString(Math.Truncate(result)).Length;
                        string str = Math.Round(result, 10 - s).ToString();
                        textBox1.Text = Convert.ToString(str).Replace(',', '.');
                        left = 0; right = 0;
                        break;
                    }
                    case '/':
                    {
                        result = left / Convert.ToDouble(textBox1.Text.Replace('.', ','));
                        int s = Convert.ToString(Math.Truncate(result)).Length;
                        string str = Math.Round(result, 10 - s).ToString();
                        textBox1.Text = Convert.ToString(str).Replace(',', '.');
                        left = 0; right = 0;
                        break;
                    }
                    default: break;
                }
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (power) 
            {
                oper = '+';
                if (left == 0) 
                {
                    left = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    textBox1.Text = "0";
                }
                else
                {
                    right = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                    left = left + right;
                    textBox1.Text = "0";
                }
            }
        }
    }
}

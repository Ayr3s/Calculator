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
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;

            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void ClearE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(value != 0)
            {
                enter.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equasion.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equasion.Text = value + " " + operation;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            equasion.Text = "";
            switch(operation)
            {
                case "+":
                    //result.Text = (value + Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Add(value, Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    //result.Text = (value - Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Sub(value, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    //result.Text = (value * Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Mul(value, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    //result.Text = (value / Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Div(value, Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            value = Double.Parse(result.Text);
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equasion.Text = "Nothing yet!";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    mul.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    enter.PerformClick();
                    break;
                case ",":
                    dot.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}

﻿using System;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        Double valuee = 0;
        String operation = "";
        bool operation_pressed = false;
        bool sqrt_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string textFromForm2,string textFroForm22)
        {
            InitializeComponent();
            result.Text = Operators.Wur(int.Parse(textFroForm22), int.Parse(textFromForm2)).ToString();
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

            if(valuee != 0)
            {
                enter.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equasion.Text = valuee + " " + operation;
            }
            else
            {
                operation = b.Text;
                valuee = Double.Parse(result.Text);
                operation_pressed = true;
                equasion.Text = valuee + " " + operation;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            equasion.Text = "";
            switch(operation)
            {
                case "+":
                    //result.Text = (value + Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Add(valuee, Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    //result.Text = (value - Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Sub(valuee, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    //result.Text = (value * Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Mul(valuee, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    //result.Text = (value / Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Div(valuee, Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            valuee = Double.Parse(result.Text);
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            valuee = 0;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            /*Button b = (Button)sender;
            b.BackColor = Color.Blue;*/
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            /*if(sqrt_pressed)
            {
                //result.Text = Operators.Wur(Double.Parse(frm1.Grad)).ToString();
                result.Text = frm.Grad;
                sqrt_pressed = false;
            }
            else
            {
                new Form2().Show();
                sqrt_pressed = true;
            }*/
            new Form2().Show();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

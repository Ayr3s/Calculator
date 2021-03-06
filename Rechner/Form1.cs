﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Double valuee = 0;
        String operation = "";
        bool operation_pressed = false;
        string X = "";
        string Y = "";
        string Z = "";

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string textFromForm2,string textFroForm22)
        {
            InitializeComponent();
            result.Text = Operators.Wur(Double.Parse(textFroForm22), Double.Parse(textFromForm2)).ToString();
            equasion.Text = "Die " + textFromForm2 + ". Wurzel von " + textFroForm22;
            operation_pressed = true;
        }
        public Form1(string textFromForm2, string textFroForm22, string textFromForm222)
        {
            InitializeComponent();
            result.Text = Operators.Zin(Double.Parse(textFroForm22), Double.Parse(textFromForm2), Double.Parse(textFromForm222)).ToString();
            equasion.Text = textFroForm22 + "€ haben nach " + textFromForm222 + " Jahren,diesen Betrag erziehlt:";
            operation_pressed = true;
        }
        public Form1(string textFromForm2, string textFroForm22, string n1, string n2)
        {
            InitializeComponent();
            result.Text = Operators.Log(Double.Parse(textFroForm22), Double.Parse(textFromForm2)).ToString();
            equasion.Text = "Der Logarithmus der Zahl " + textFroForm22 + " mit der Basis " + textFromForm2 + ":";
            operation_pressed = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed) || (equasion.Text == "Nothing yet!"))
            {
                result.Clear();
                equasion.Text = "";
            }

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
            equasion.Text = "Nothing yet!";
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
            equasion.Text = "Nothing yet!";
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
            Hide();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zins_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            menuStrip1.BackColor = Color.DarkGray;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            menuStrip1.BackColor = Color.AntiqueWhite;
        }

        private void darkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            one.BackColor = Color.Gray;
            two.BackColor = Color.Gray;
            three.BackColor = Color.Gray;
            four.BackColor = Color.Gray;
            five.BackColor = Color.Gray;
            six.BackColor = Color.Gray;
            seven.BackColor = Color.Gray;
            eight.BackColor = Color.Gray;
            nine.BackColor = Color.Gray;
            zero.BackColor = Color.Gray;
            plus.BackColor = Color.Gray;
            minus.BackColor = Color.Gray;
            div.BackColor = Color.Gray;
            mul.BackColor = Color.Gray;
            sqrt.BackColor = Color.Gray;
            dot.BackColor = Color.Gray;
            Zins.BackColor = Color.Gray;
            Clear.BackColor = Color.Gray;
            ClearE.BackColor = Color.Gray;
            enter.BackColor = Color.Gray;
            button18.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            one.BackColor = Color.White;
            two.BackColor = Color.White;
            three.BackColor = Color.White;
            four.BackColor = Color.White;
            five.BackColor = Color.White;
            six.BackColor = Color.White;
            seven.BackColor = Color.White;
            eight.BackColor = Color.White;
            nine.BackColor = Color.White;
            zero.BackColor = Color.White;
            plus.BackColor = Color.White;
            minus.BackColor = Color.White;
            div.BackColor = Color.White;
            mul.BackColor = Color.White;
            sqrt.BackColor = Color.White;
            dot.BackColor = Color.White;
            Zins.BackColor = Color.White;
            Clear.BackColor = Color.White;
            ClearE.BackColor = Color.White;
            enter.BackColor = Color.White;
            button18.BackColor = Color.White;
        }

        private void darkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
            result.ForeColor = Color.Black;
            equasion.ForeColor = Color.DarkGray;
        }

        private void whiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            result.ForeColor = Color.White;
            equasion.ForeColor = Color.DeepSkyBlue;
        }

        private void darkToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            result.BackColor = Color.Gray;
            //equasion.BackColor = Color.DarkGray;
        }

        private void whiteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            result.BackColor = Color.AntiqueWhite;
            //equasion.BackColor = Color.AntiqueWhite;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            one.BackColor = Color.DeepSkyBlue;
            two.BackColor = Color.DeepSkyBlue;
            three.BackColor = Color.DeepSkyBlue;
            four.BackColor = Color.DeepSkyBlue;
            five.BackColor = Color.DeepSkyBlue;
            six.BackColor = Color.DeepSkyBlue;
            seven.BackColor = Color.DeepSkyBlue;
            eight.BackColor = Color.DeepSkyBlue;
            nine.BackColor = Color.DeepSkyBlue;
            zero.BackColor = Color.DeepSkyBlue;
            plus.BackColor = Color.DeepSkyBlue;
            minus.BackColor = Color.DeepSkyBlue;
            div.BackColor = Color.DeepSkyBlue;
            mul.BackColor = Color.DeepSkyBlue;
            sqrt.BackColor = Color.DeepSkyBlue;
            dot.BackColor = Color.DeepSkyBlue;
            Zins.BackColor = Color.DeepSkyBlue;
            Clear.BackColor = Color.DeepSkyBlue;
            ClearE.BackColor = Color.DeepSkyBlue;
            enter.BackColor = Color.DeepSkyBlue;
            button18.BackColor = Color.DeepSkyBlue;
            this.BackColor = Color.DarkBlue;
            menuStrip1.BackColor = Color.DarkBlue;
            result.BackColor = Color.DeepSkyBlue;
            this.ForeColor = Color.AntiqueWhite;
            result.ForeColor = Color.AntiqueWhite;
            equasion.ForeColor = Color.Gray;
        }

        private void darkToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            one.BackColor = Color.DarkGray;
            two.BackColor = Color.DarkGray;
            three.BackColor = Color.DarkGray;
            four.BackColor = Color.DarkGray;
            five.BackColor = Color.DarkGray;
            six.BackColor = Color.DarkGray;
            seven.BackColor = Color.DarkGray;
            eight.BackColor = Color.DarkGray;
            nine.BackColor = Color.DarkGray;
            zero.BackColor = Color.DarkGray;
            plus.BackColor = Color.DarkGray;
            minus.BackColor = Color.DarkGray;
            div.BackColor = Color.DarkGray;
            mul.BackColor = Color.DarkGray;
            sqrt.BackColor = Color.DarkGray;
            dot.BackColor = Color.DarkGray;
            Zins.BackColor = Color.DarkGray;
            Clear.BackColor = Color.DarkGray;
            ClearE.BackColor = Color.DarkGray;
            enter.BackColor = Color.DarkGray;
            button18.BackColor = Color.DarkGray;
            this.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.Gray;
            result.BackColor = Color.DarkGray;
            this.ForeColor = Color.Black;
            result.ForeColor = Color.Black;
            equasion.ForeColor = Color.AntiqueWhite;
        }

        private void whiteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            one.BackColor = Color.White;
            two.BackColor = Color.White;
            three.BackColor = Color.White;
            four.BackColor = Color.White;
            five.BackColor = Color.White;
            six.BackColor = Color.White;
            seven.BackColor = Color.White;
            eight.BackColor = Color.White;
            nine.BackColor = Color.White;
            zero.BackColor = Color.White;
            plus.BackColor = Color.White;
            minus.BackColor = Color.White;
            div.BackColor = Color.White;
            mul.BackColor = Color.White;
            sqrt.BackColor = Color.White;
            dot.BackColor = Color.White;
            Zins.BackColor = Color.White;
            Clear.BackColor = Color.White;
            ClearE.BackColor = Color.White;
            enter.BackColor = Color.White;
            button18.BackColor = Color.White;
            this.BackColor = Color.AntiqueWhite;
            menuStrip1.BackColor = Color.AntiqueWhite;
            result.BackColor = Color.White;
            this.ForeColor = Color.Gray;
            result.ForeColor = Color.Gray;
            equasion.ForeColor = Color.DarkGray;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveModeToolStripMenuItem.Checked==true)
            {
                X = result.Text;
                equasion.Text = result.Text + " ist in X gespeichert";
                operation_pressed = true;
            }
            else if (X == "")
            {
                equasion.Text = "Keine Wert in X gespeichert";
                operation_pressed = true;
            }
            else
            {
                result.Text = X;
            }
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveModeToolStripMenuItem.Checked == true)
            {
                Y = result.Text;
                equasion.Text = result.Text + " ist in Y gespeichert";
                operation_pressed = true;
            }
            else if (X == "")
            {
                equasion.Text = "Keine Wert in Y gespeichert";
                operation_pressed = true;
            }
            else
            {
                result.Text = X;
            }
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveModeToolStripMenuItem.Checked == true)
            {
                Z = result.Text;
                equasion.Text = result.Text + " ist in Z gespeichert";
                operation_pressed = true;
            }
            else if (X == "")
            {
                equasion.Text = "Keine Wert in Z gespeichert";
                operation_pressed = true;
            }
            else
            {
                result.Text = X;
            }
        }

        private void resetVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equasion.Text = "Variablen zurückgesetzt";
            X = "";
            Y = "";
            Z = "";
            operation_pressed = true;
        }
    }
}

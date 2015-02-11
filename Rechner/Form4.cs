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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = "y";
            string n2 = "y";
            Form1 frm = new Form1(grad.Text, zahl.Text, n1, n2);
            frm.ShowDialog();
            frm.Close();
            this.Hide();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public string Grad
        {
            get
            {
                return boxtext.Text;
            }
        }

        public string Num
        {
            get
            {
                return Zahl.Text;
            }
        }

        public void ok_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(boxtext.Text,Zahl.Text);
            frm.ShowDialog();
            frm.Close();
            this.Hide();
        }
    }
}

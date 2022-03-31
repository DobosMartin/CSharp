using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210127
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "+";
            label4.Text = "=";
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = ":";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double TextBox1 = double.Parse(label1.Text);
            double TextBox2 = double.Parse(label2.Text);
            double eredmeny=0;
            switch (label3.Text)
            {
                case"+":
                    eredmeny = TextBox1 + TextBox2;
                    break;
                case "-":
                    eredmeny = TextBox1 - TextBox2;
                    break;
                case "*":
                    eredmeny = TextBox1 * TextBox2;
                    break;
                case "/":
                    eredmeny = TextBox1 / TextBox2;
                    break;
            }
            label5.Text = "=" + eredmeny;
        }
    }
}

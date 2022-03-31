using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20210215
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            radioA.Checked = false;
            radioB.Checked = false;
            radioC.Checked = true;

        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string kiir;
            if (radioA.Checked)
            {
                b = double.Parse(txtB.Text);
                c = double.Parse(txtC.Text);
                a = Math.Pow(b,1/c);
                txtA.Text = Convert.ToString(Math.Round(a, 2));
            }
            else if (radioB.Checked)
            {
                a = double.Parse(txtA.Text);
                c = double.Parse(txtC.Text);
                b = Math.Pow(a,c);
                txtB.Text = Convert.ToString(Math.Round(b, 2));
            }
            else
            {
                b = double.Parse(txtB.Text);
                a = double.Parse(txtA.Text);
                c = Math.Log(b, a);
                txtC.Text = Convert.ToString(Math.Round(c, 2));
            }
            kiir = txtA.Text + ";" + txtB.Text + ";" + txtC + ";";
            File.AppendAllText("logaritmus.csv", kiir);
        }
    }
}

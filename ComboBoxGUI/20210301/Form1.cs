using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210301
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                comboBox1.Items.Add(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.DropDownStyle)
            {
                case ComboBoxStyle.Simple:
                    comboBox1.DropDownStyle =
ComboBoxStyle.DropDown;
                    button3.Text = "DropDown";
                    break;
                case ComboBoxStyle.DropDown:
                    comboBox1.DropDownStyle =
ComboBoxStyle.DropDownList;
                    button3.Text = "DropDownList";
                    break;
                case ComboBoxStyle.DropDownList:
                    comboBox1.DropDownStyle =
ComboBoxStyle.Simple;
                    button3.Text = "Simple";
                    break;
            }
        }
    }
}

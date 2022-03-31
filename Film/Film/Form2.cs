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

namespace Film
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public ListBox lb2;
        public Form2()
        {
            instance = this;
            InitializeComponent();
            lb2 = listBox2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnhome_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnfrissit_MouseClick(object sender, MouseEventArgs e)
        {
            lb2.Items.Clear();
            string[] lines = File.ReadAllLines("sorozat.txt");
            foreach (string line in lines)
            {
                Form2.instance.lb2.Items.Add(line);
            }
        }

        private void btntalca_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnminmax_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnbezar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit(); 
        }
    }
}

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
    public partial class Kereso : Form
    {
        private int borderSize = 2;
        public static Kereso instance;
        public ListBox l1;
        public Kereso()
        {
            InitializeComponent();
            instance = this;
            l1 = lbxhiden;
        }
        private void Kereso_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btntalca_Click(object sender, EventArgs e)
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

        private void btnminmax_Click(object sender, EventArgs e)
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

        private void btnbezar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtkereso_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string keres = txtkereso.Text;
            if (txtkereso.Text == "")
            {
                listBox1.Items.Clear();
            }
            else
            {
                foreach (string s in lbxhiden.Items)
                {
                    if (s.Contains(keres))
                    {
                       listBox1.Items.Add(s);
                    }
                }
            }
        }

        private void btnhome_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}

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
    public partial class filmek : Form
        
    {
        public ListBox lfilm;
        public static filmek instance;
        public filmek()
        {
            InitializeComponent();
            instance = this;
            lfilm = lfilmek;
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

        private void btnfrissit_MouseClick(object sender, MouseEventArgs e)
        {
            lfilmek.Items.Clear();
            string[] lines = File.ReadAllLines("film.txt");
            foreach (string line in lines)
            {
               filmek.instance.lfilm.Items.Add(line);
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

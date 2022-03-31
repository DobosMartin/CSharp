using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_evszak_Click(object sender, EventArgs e)
        {
            int evszak = Convert.ToInt32(txt_evszak.Text);
            if (evszak == 1 || evszak == 2 || evszak==12 )
            {
                lbl_evszak.Text = ("Tél");
            }
            else if (evszak == 3 || evszak == 4 || evszak == 5)
            {
                lbl_evszak.Text = ("Tavasz");
            }
            else if (evszak == 6 || evszak == 7 || evszak == 8)
            {
                lbl_evszak.Text = ("Nyár");
            }
            else if (evszak == 9 || evszak == 10 || evszak == 11)
            {
                lbl_evszak.Text = ("Ősz");
            }
            else if ( evszak < 12 )
            {
                lbl_evszak.Text = ("Ilyen hónap nincs!");
            }
        }
    }
}

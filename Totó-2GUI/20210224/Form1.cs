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

namespace _20210224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnev_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipp_TextChanged(object sender, EventArgs e)
        {
            string tippek = txtTipp.Text;
            if (tippek != "")
            {
                string[] darabok = tippek.Trim().Split(' ');
                int tippekszama = darabok.Length;
                lblDB.Text = tippekszama + " db";
            }
            else
            {
                lblDB.Text = "0 db";
            }

        }

        private void txtTipp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnhozzaad_Click(object sender, EventArgs e)
        {
            string nev = txtnev.Text.Trim();
            string tipp = txtTipp.Text.Trim();
            int tippdb = tipp.Split(' ').Length;
            if (nev == "")
            {
                MessageBox.Show("nem adtad meg a nevet.");
            }
            else if (tipp == "")
            {
                MessageBox.Show("nem adtad meg a tippeket.");
            }
            else if (File.Exists("tippek.txt"))
            {
                string[] beolvas = File.ReadAllLines("tippek.txt");
                int tippszam = beolvas[0].Trim().Split(' ').Length - 1;
                string beolvas1 = File.ReadAllText("tippek.txt");
                if (beolvas1.Contains(nev))
                {
                    MessageBox.Show("Van már ilyen nevű játékos");
                }
                else if (tippdb == tippszam)
                {
                    File.AppendAllText("tippek.txt", nev + " " + tipp + "\n");
                    txtnev.Text = "";
                    txtTipp.Text = "";
                    MessageBox.Show("az allomány bővítése sikeres volt!");
                }
                else
                {
                    MessageBox.Show("A tippek száma nem megfelelő");
                }
            }
            else
            {
                File.WriteAllText("tippek.txt", nev + " " + tipp + "\n");
            }
        }
    }
}

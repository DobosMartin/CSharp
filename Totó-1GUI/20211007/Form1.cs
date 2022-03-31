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

namespace _20211007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_db_Click(object sender, EventArgs e)
        {

        }

        private void Btn_hozzaad_Click(object sender, EventArgs e)
        {
            if (txt_nev.Text != "" && txt_tipp.Text != "" )
            {
                if (File.Exists("tippek.txt"))
                {
                    string osszes = File.ReadAllText("tippek.txt");
                    if (osszes.Contains(txt_nev.Text))
                    {
                        MessageBox.Show("A név már szerepel az adatbázisban.");
                    }
                    else
                    {


                        string[] beolvas = File.ReadAllLines("tippek.txt");
                        int tippekszama = beolvas[0].Trim().Split(' ').Length - 1;
                        int tippszam = txt_tipp.Text.Trim().Split(' ').Length;
                        if (tippekszama == tippszam)
                        {
                            File.AppendAllText("tippek.txt", txt_nev.Text + " " + txt_tipp.Text + "\n");
                            MessageBox.Show("Az állomány bővítése sikeres volt.");
                        }
                        else
                        {
                            MessageBox.Show("A tippek száma nem megfelelő.");
                        }
                    }
                }
                else
                {
                    File.AppendAllText("tippek.txt", txt_nev.Text + " " + txt_tipp.Text + "\n");
                    MessageBox.Show("Az állomány bővítése sikeres volt.");
                }
            }
            else if (txt_nev.Text == "" && txt_tipp.Text != "")
            {
                MessageBox.Show("Add meg a nevet.");
            }
            else if (txt_tipp.Text == "" && txt_nev.Text != "")
            {
                MessageBox.Show("Add meg a tippeket.");
            }
            else if (txt_nev.Text == "" && txt_tipp.Text == "")
            {
                MessageBox.Show("Add meg a nevet és a tippeket.");
            }
            

        }

        private void Txt_tipp_TextChanged(object sender, EventArgs e)
        {
            string tartalom = txt_tipp.Text.Trim();
            int db = tartalom.Split(' ').Length;
            lbl_db.Text = db + " db";
        }
    }
}

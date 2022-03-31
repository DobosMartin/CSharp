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

namespace _20220222_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (txt_ev.Text == "" || txt_nev.Text == "" || txt_szh.Text == "" ||txt_orszag.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
            }
            else
            {
                try
                {
                    int ev = int.Parse(txt_ev.Text);
                    if (ev > 1989)
                    {
                        if (!File.Exists(" uj_dijazott.txt"))
                        {
                            File.AppendAllText(" uj_dijazott.txt", txt_ev.Text + ";" + txt_nev.Text + ";" + txt_szh.Text + ";" + txt_orszag.Text);
                            MessageBox.Show("Mentés... \t Mentve!");
                            txt_ev.Clear();
                            txt_nev.Clear();
                            txt_szh.Clear();
                            txt_orszag.Clear();
                        }
                        else
                        {
                            File.AppendAllText(" uj_dijazott.txt", txt_ev.Text + ";" + txt_nev.Text + ";" + txt_szh.Text + ";" + txt_orszag.Text);
                            MessageBox.Show("Mentés... \t Mentve!");
                            txt_ev.Clear();
                            txt_nev.Clear();
                            txt_szh.Clear();
                            txt_orszag.Clear();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                    }
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Hiba az állomány írásánál!");
                }
            }
        }
    }
}
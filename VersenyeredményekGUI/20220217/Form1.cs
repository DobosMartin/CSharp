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

namespace _20220217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbx_nevek.Visible = false;
        }

        private void Btn_rogzit_Click(object sender, EventArgs e)
        {
            
            List<string> nevek = new List<string>();
            if (txt_nev.Text == "")
            {
                MessageBox.Show("Nem adtad meg a versenyző nevét!");
            }
            else if (txt_nemz.Text == "")
            {
                MessageBox.Show("Nem adtad meg a versenyző nemzetiségét!");
            }
            else if (txt_pont1.Text == "" || txt_pont2.Text == "" || txt_pont3.Text == "")
            {
                MessageBox.Show("Valamelyik pontszámot nem jól adtad meg");
            }
            
            try
            {
                double pont1, pont2, pont3;
                pont1 = double.Parse(txt_pont1.Text);
                pont2 = double.Parse(txt_pont2.Text);
                pont3 = double.Parse(txt_pont3.Text);
                if (pont1 < 0 || pont1 > 100 || pont2 < 0 || pont2 > 100 || pont3 < 0 || pont3 > 100)
                {
                    MessageBox.Show("Valamelyik pontszám nem esik 0 és 100 közé!");
                }
                else if (pont1 > 0 && pont1 < 100 || pont2 > 0 && pont2 < 100 || pont3 > 0 && pont3 < 100)
                {

                    if (!lbx_nevek.Items.Contains(txt_nev.Text))
                    {
                        lbx_nevek.Items.Add(txt_nev.Text);
                        if (!File.Exists("eredmenyek.txt"))
                        {
                            File.AppendAllText("eredmenyek.txt", txt_nev.Text + ";" + txt_nemz.Text + ";" + txt_pont1.Text + ";" + txt_pont2.Text + ";" + txt_pont3.Text + "\n");
                            MessageBox.Show("Sikeres mentés!");
                            txt_nev.Clear();
                            txt_nemz.Clear();
                            txt_pont1.Clear();
                            txt_pont2.Clear();
                            txt_pont3.Clear();
                        }
                        else
                        {
                            File.AppendAllText("eredmenyek.txt", txt_nev.Text + ";" + txt_nemz.Text + ";" + txt_pont1.Text + ";" + txt_pont2.Text + ";" + txt_pont3.Text + "\n");
                            MessageBox.Show("Sikeres mentés!");
                            txt_nev.Clear();
                            txt_nemz.Clear();
                            txt_pont1.Clear();
                            txt_pont2.Clear();
                            txt_pont3.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Van már ilyen nevű versenyző!");
                    }
                }
                
                
                
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Valamelyik pontszámot nem jól adtad meg");
            }
        }
    }
}

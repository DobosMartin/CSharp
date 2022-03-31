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

namespace _20211202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_beolvas_Click(object sender, EventArgs e)
        {
            if (!File.Exists("valaszok.txt"))
            {
                MessageBox.Show("Nincs ilyen fájl.");
            }
            else
            {
                string[] beolvas = File.ReadAllLines("valaszok.txt");
                foreach (var item in beolvas)
                {
                    listBox1.Items.Add(item);
                }
                MessageBox.Show("Sikeres feltöltés!");
            }
        }

        private void Btn_keres_Click(object sender, EventArgs e)
        {
            List<string> elemek = new List<string>();
            foreach (var item in listBox1.Items)
            {
                elemek.Add(item.ToString());
            }
            listBox1.Items.Clear();
            foreach (var item in elemek)
            {
                if (item.Contains(txt_kod.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void Btn_hozzaad_Click(object sender, EventArgs e)
        {
            string valasz = txt_valasz.Text;
            for (int i = 0; i < valasz.Length; i++)
            {
                if (valasz[i]=='A' || valasz[i] == 'B' || valasz[i] == 'C' || valasz[i] == 'D' || valasz[i] == 'X')
                {
                    if (txt_kod.Text.Length == 5 && txt_valasz.Text.Length < 14)
                    {
                        if (txt_kod.Text != "" && txt_valasz.Text != "")
                        {
                            listBox1.Items.Add(txt_kod.Text + " " + txt_valasz.Text);
                        }
                        else
                        {
                            MessageBox.Show("Hiányzik egy beviteli meződ.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Túl hosszú vagy rövid a kód/válasz");
                    }
                }
                else
                {
                    MessageBox.Show("Hibás válaszok.");
                }
            }
            
                
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ment_Click(object sender, EventArgs e)
        {
            if (txt_kod.Text != "" && txt_valasz.Text != "" )
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ok = txt_kod.Text + " " + txt_valasz.Text + " ";
                    File.AppendAllText(saveFileDialog1.FileName, ok);
                    MessageBox.Show("Sikeres mentés!");
                }
            }
            else
            {
                MessageBox.Show("Nem adtad meg az összes értéket!");
            }
        }

        private void Btn_vissza_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!listBox1.Items.Contains("valaszok.txt"))
            {
               string[] beolvas = File.ReadAllLines("valaszok.txt");
               foreach (var item in beolvas)
               {
                  listBox1.Items.Add(item);
               }
            }
        }

        private void Txt_valasz_TextChanged(object sender, EventArgs e)
        {
            if (txt_valasz.Text.Length < 14 && txt_kod.Text.Length == 5)
            {
                btn_hozzaad.Enabled = true;
            }
        }
    }
}


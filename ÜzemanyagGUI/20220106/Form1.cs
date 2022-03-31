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

namespace _20220106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_listbox_Click(object sender, EventArgs e)
        {
            if (txt_datum.Text == "")
            {
                MessageBox.Show("Hiányzik a dátum!");
            }
            else if (txt_benzin.Text == "")
            {
                MessageBox.Show("Hiányzik a benzin ára!");
            }
            else if (txt_gazolaj.Text == "")
            {
                MessageBox.Show("Hiányzik a gázolaj ára!");
            }
            else
            {
                lbx_adatok.Items.Add(txt_datum.Text + ";" + txt_benzin.Text + ";" + txt_gazolaj.Text);
            }
        }

        private void Btn_menttorol_Click(object sender, EventArgs e)
        {


            if (File.Exists("uzemanyag.txt"))
            {
                string kiir = txt_datum.Text + ";" + txt_benzin.Text + ";" + txt_gazolaj.Text;
                File.AppendAllText("uzemanyag.txt", kiir + "\n");
                txt_datum.Text = "";
                txt_benzin.Text = "";
                txt_gazolaj.Text = "";
                MessageBox.Show("Sikeres mentés");
                lbx_adatok.Items.Clear();
            }
            else
            {
                string kiir = txt_datum.Text + ";" + txt_benzin.Text + ";" + txt_gazolaj.Text;
                File.AppendAllText("uzemanyag.txt", kiir + "\n");
                txt_datum.Text = "";
                txt_benzin.Text = "";
                txt_gazolaj.Text = "";
                MessageBox.Show("Sikeres mentés");
            }
        }




        private void Btn_feltölt_Click(object sender, EventArgs e)
        {
            if (!File.Exists("uzemanyag.txt"))
            {
                MessageBox.Show("Nincs ilyen fájl.");
            }
            else
            {
                string[] beolvas = File.ReadAllLines("uzemanyag.txt");
                foreach (var item in beolvas)
                {
                    lbx_adatok.Items.Add(item);
                }
                MessageBox.Show("Sikeres feltöltés!");
            }
        }

        private void Btn_datumkeres_Click(object sender, EventArgs e)
        {
            List<string> elemek = new List<string>();
            foreach (var item in lbx_adatok.Items)
            {
                elemek.Add(item.ToString());
            }
            lbx_adatok.Items.Clear();
            foreach (var item in elemek)
            {
                if (item.Contains(txt_datum.Text))
                {
                    lbx_adatok.Items.Add(item);
                }
            }
        }
    }
}

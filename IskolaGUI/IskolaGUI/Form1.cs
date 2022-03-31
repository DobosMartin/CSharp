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

namespace IskolaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("IskolaGUI.txt");
            foreach (var item in beolvas)
            {
                lbx_adatok.Items.Add(item);
            } 
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            if (lbx_adatok.SelectedIndex>=0)
            {
                lbx_adatok.Items.Remove(lbx_adatok.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelölt ki tanulót!");
            }
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {
            List<string> adatok = new List<string>();
            string[] beolvas = File.ReadAllLines("IskolaGUI.txt");
            try
            {
                if (File.Exists("nevekNEW.txt"))
                {
                    File.Delete("nevekNEW.txt");
                    foreach (var item in lbx_adatok.Items)
                    {
                        File.AppendAllText("nevekNEW.txt", item.ToString() + "\n");
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
                else
                {
                    foreach (var item in lbx_adatok.Items)
                    {
                        File.AppendAllText("nevekNEW.txt", item.ToString() + "\n");
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

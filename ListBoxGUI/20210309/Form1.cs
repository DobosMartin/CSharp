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

namespace _20210309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            if(txtHozzaad.Text!="")
            {
                lbxElemek.Items.Add(txtHozzaad.Text);
                btn_alulra.Enabled = true;
                btn_felulre.Enabled = true;
                btn_fel.Enabled = true;
                btn_le.Enabled = true;
                btn_rendezes.Enabled = true;
            }
        }

        private void btn_rendezes_Click(object sender, EventArgs e)
        {
            lbxElemek.Sorted = true;
        }

        private void btn_olvas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string[] beolvas = File.ReadAllLines(openFileDialog1.FileName);
                foreach (var item in beolvas)
                {
                    lbxElemek.Items.Add(item);
                }
            }
            btn_alulra.Enabled = true;
            btn_felulre.Enabled = true;
            btn_fel.Enabled = true;
            btn_le.Enabled = true;
            btn_rendezes.Enabled = true;
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex==-1)
            {
                MessageBox.Show("Nincs kiválasztott elem");
            }
            else
            {
                lbxElemek.Items.RemoveAt(lbxElemek.SelectedIndex);
            }
        }

        private void btn_iras_Click(object sender, EventArgs e)
        {
            if (lbxElemek.Items.Count>0)
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    foreach (var item in lbxElemek.Items)
                    {
                        File.AppendAllText(saveFileDialog1.FileName, item + "\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("Üres a lista!");
            }
        }

        private void btn_felulre_Click(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex==-1)
            {
                MessageBox.Show("Nem választottál elemet");
            }
            else
            {
                lbxElemek.Items.Insert(0, lbxElemek.SelectedItem);
                lbxElemek.Items.RemoveAt(lbxElemek.SelectedIndex);
            }
        }

        private void btn_fel_Click(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex == -1)
            {
                MessageBox.Show("Nem választottál elemet");
            }
            else
            {
                lbxElemek.Items.Insert(lbxElemek.SelectedIndex - 1, lbxElemek.SelectedItem);
                lbxElemek.Items.RemoveAt(lbxElemek.SelectedIndex);
            }
        }

        private void btn_le_Click(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex == -1)
            {
                MessageBox.Show("Nem választottál elemet");
            }
            else
            {
                lbxElemek.Items.Insert(lbxElemek.SelectedIndex + 2, lbxElemek.SelectedItem);
                lbxElemek.Items.RemoveAt(lbxElemek.SelectedIndex);
            }
        }

        private void btn_alulra_Click(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex == -1)
            {
                MessageBox.Show("Nem választottál elemet");
            }
            else
            {
                lbxElemek.Items.Add(lbxElemek.SelectedItem);
                lbxElemek.Items.RemoveAt(lbxElemek.SelectedIndex);
            }
        }

        private void lbxElemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxElemek.SelectedIndex == 0)
            {
                btn_felulre.Enabled = false;
                btn_fel.Enabled = false;
                btn_le.Enabled = true;
                btn_alulra.Enabled = true;
            }
            else if (lbxElemek.SelectedIndex == lbxElemek.Items.Count-1)
            {
                btn_felulre.Enabled = true;
                btn_fel.Enabled = true;
                btn_le.Enabled = false;
                btn_alulra.Enabled = false;
            }
            else
            {
                btn_felulre.Enabled = true;
                btn_fel.Enabled = true;
                btn_le.Enabled = true;
                btn_alulra.Enabled = true;
            }
        }
    }
}

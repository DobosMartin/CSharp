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

namespace VarazsloIskolaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_mentes_Click(object sender, EventArgs e)
        {
            if (txt_tanonc.Text == "" || cmb_troll.Text == "" || cmb_igyekezet.Text == "" || txt_kipurcan.Text == "" || txt_logas.Text == "")
            {
                MessageBox.Show("Elvarázsollak, ha nem töltesz ki minden mezőt!","A manóba!");
            }
            else
            {
                try
                {
                    int kipurcantan = Convert.ToInt32(txt_kipurcan.Text);
                    int logastan = Convert.ToInt32(txt_logas.Text);
                    if (kipurcantan >= 0|| logastan >= 0)
                    {
                        if (!File.Exists("uj_tanonc.txt"))
                        {
                            File.AppendAllText("uj_tanonc.txt",  txt_tanonc.Text + ";" + cmb_troll.SelectedItem + ";" + cmb_igyekezet.SelectedItem + ";" + txt_kipurcan.Text + ";" + txt_logas.Text + ";" + "\n");
                            MessageBox.Show("A varázslat sikeres!", "Transportus");
                            txt_tanonc.Clear();
                            cmb_troll.Text = "";
                            cmb_igyekezet.Text = "";
                            txt_kipurcan.Clear();
                            txt_logas.Clear();
                            
                        }
                        else
                        {
                            File.AppendAllText("uj_tanonc.txt", txt_tanonc.Text + ";" + cmb_troll.SelectedItem + ";" + cmb_igyekezet.SelectedItem + ";" + txt_kipurcan.Text + ";" + txt_logas.Text + ";" + "\n");
                            MessageBox.Show("A varázslat sikeres!", "Transportus");
                            txt_tanonc.Clear();
                            cmb_troll.Text = "";
                            cmb_igyekezet.Text = "";
                            txt_kipurcan.Clear();
                            txt_logas.Clear();
                        }
                        
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Számisztikából borzalmas!", "A manóba!");
                }
            }
        }
    }
}

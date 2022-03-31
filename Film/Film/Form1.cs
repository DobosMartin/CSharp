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
using System.Runtime.InteropServices;

namespace Film
{
    public partial class Form1 : Form
    {
        public static string atvitel;
        private int borderSize = 2;
        public static Form1 instance;
        public TextBox  tb1;
        public Form1()
        {
            InitializeComponent();
            instance=this;
            tb1 = txt_nev;
            this.Padding = new Padding(borderSize);
            comboevadok.Visible = false;
            lblevad.Visible = false;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

      

            private void Form1_Resize(object sender, EventArgs e)
            {
                AdjustForm();
            }
        

            private void AdjustForm()
            {
                switch (this.WindowState)
                {
                    case FormWindowState.Maximized: //Maximized form (After)
                        this.Padding = new Padding(8, 8, 8, 0);
                        break;
                    case FormWindowState.Normal: //Restored form (After)
                        if (this.Padding.Top != borderSize)
                            this.Padding = new Padding(borderSize);
                        break;
                }
            }
            private void btn_hozzaad_Click(object sender, EventArgs e)
            {
                if (txt_nev.Text != "")
                {
                    if (File.Exists("osszes.txt"))
                    {
                        string ossz = File.ReadAllText("osszes.txt");
                        if (ossz.Contains(txt_nev.Text + " " + comboevadok.SelectedItem + ".Évad"))
                        {
                            MessageBox.Show("Ez a film/sorozat szerepel már a listán!");
                            txt_nev.Clear();
                            txt_nev.Focus();
                            combofs.SelectedItem = " ";
                    }
                        else 
                        {
                            if (Form1.instance.combofs.SelectedItem.ToString() == "Film")
                            {
                                File.AppendAllText("osszes.txt", txt_nev.Text + "\n");
                                File.AppendAllText("film.txt", txt_nev.Text + "\n");
                                MessageBox.Show("Sikeresen hozzáadva a listához");
                                txt_nev.Clear();
                                txt_nev.Focus();
                                combofs.SelectedItem = " ";
                        }
                            else if (Form1.instance.combofs.SelectedItem.ToString() == "Sorozat")
                            {
                                if (comboevadok.SelectedItem != "")
                                {
                                    File.AppendAllText("osszes.txt", txt_nev.Text + " " + comboevadok.SelectedItem + ".Évad" + "\n");
                                    File.AppendAllText("Sorozat.txt", txt_nev.Text + " " + comboevadok.SelectedItem + ".Évad" + "\n");
                                    MessageBox.Show("Sikeresen hozzáadva a listához");
                                    txt_nev.Clear();
                                    txt_nev.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Nem adtál meg évadot");
                                }
                            }
                        }
                    }
                }
                else if (txt_nev.Text == "")
                {
                    MessageBox.Show("Nem adtál meg semmi címet");
                }
            }


            private void btnbezar_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnminmax_Click(object sender, EventArgs e)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
            }

            private void btntalca_Click(object sender, EventArgs e)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Minimized;
                }
                else if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }
            }

            private void panel1_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

        private void btnkereso_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Kereso kereso = new Kereso();
            kereso.Show();
            Kereso.instance.l1.Visible = false;
            string[] lines = File.ReadAllLines("osszes.txt");
            foreach (string line in lines)
            {
              Kereso.instance. l1.Items.Add(line);
            }
            Kereso.instance.l1.Sorted = true;
        }

        private void btnfilmek_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            filmek filmek = new filmek();
            filmek.Show();
            string[] lines = File.ReadAllLines("film.txt");
            foreach (string line in lines)
            {
                filmek.instance.lfilm.Items.Add(line);
            }
            filmek.instance.lfilm.Sorted = true;
        }

        private void btnsorozatok_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            string[] lines = File.ReadAllLines("sorozat.txt");
            foreach (string line in lines)
            {
                Form2.instance.lb2.Items.Add(line);
            }
            Form2.instance.lb2.Sorted = true;
        }

        private void btnhelp_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Ha beírtad a címet, válaszd ki a típust.\n Ha a Filmet választottad csak nyomj a hozzáadra. \n Ha a Sorozatra nyomtál mindenképpen add meg az évadot.", "Információs ablak", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void combofs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofs.SelectedItem == "Sorozat")
            {
                comboevadok.Visible = true;
                lblevad.Visible = true;
            }
            else if(combofs.SelectedItem == "Film" || combofs.SelectedItem == " ")
            {
                comboevadok.Visible = false;
                lblevad.Visible = false;
            }
        }
    }
}

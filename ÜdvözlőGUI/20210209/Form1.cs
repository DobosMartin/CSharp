using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210209
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void udv_Click(object sender, EventArgs e)
        {
            udvozlo.Text = "Hello " + keresztnev.Text;
        }

        private void doktor_Click(object sender, EventArgs e)
        {
            var fullName = nevbe.Text;
            var nevek = fullName.Split(' ');

            var firstName = nevek[0];
            var lastName = "";
            for (var i = 1; i < nevek.Length; i++){
                lastName += nevek[i] + ' '; 
            }
            vezeteknev.Text = firstName.ToLower();
            keresztnev.Text = lastName.ToUpper();

            int szamlalo = 0;
            szamlalo = nevbe.Text.Length;
            hossz.Text = szamlalo.ToString();
        }

        private void vege_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void torol_Click(object sender, EventArgs e)
        {
            nevbe.Clear();
            keresztnev.Clear();
            vezeteknev.Clear();
            hossz.Clear();
        }

        private void nevbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void vezeteknev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

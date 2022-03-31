using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 150; i <= 220; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 40; i <= 120; i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int i = 10; i <= 100; i++)
            {
                comboBox3.Items.Add(i);
            }
            bodymass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "♀")
            {
                button1.Text = "♂";
            }
            else
            {
                button1.Text = "♀";
            }
            bodymass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodymass();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodymass();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodymass();
        }

        private void bodymass()
        {
            double height;
            double weight;
            double bmi;
            double age;
            height = Convert.ToDouble(comboBox1.Text) / 100;
            weight = Convert.ToDouble(comboBox2.Text);
            age = Convert.ToDouble(comboBox3.Text);

            bmi = weight / (height * height); //Testtömeg kiszámítás
            bmi = Math.Round(bmi*10)/10; //Kerekítés egy tizedesre

            label4.Text = Convert.ToString(bmi);

            //első vélemény bmi alapján

            if (bmi < 16)
                label5.Text = "súlyos soványság";
            else if (bmi > 16 && bmi < 17)
                label5.Text = "mérsékelt soványság";
            else if (bmi > 17 && bmi < 18.5)
                label5.Text = "enyhe soványság";
            else if (bmi > 18.5 && bmi < 25)
                label5.Text = "normális testsúly";
            else if (bmi > 25 && bmi < 30)
                label5.Text = "túlsúly";
            else if (bmi > 30 && bmi < 35)
                label5.Text = "enyhe elhízás";
            else if (bmi > 35 && bmi < 40)
                label5.Text = "közepes elhízás";
            else if (bmi > 40)
                label5.Text = "súlyos elhízás";

            //nők kor szerint
            if (button1.Text == "♀")
            {
              if (age < 18 && bmi > 18 && bmi < 21)
                  label5.Text = "Ideális";
              else if (age < 18 && age < 30 && bmi > 21 && bmi < 22)
                  label5.Text = "Ideális";
              else if (age < 30 && age < 35 && bmi > 22 && bmi < 23)
                  label5.Text = "Ideális";
              else if (age < 18 && age < 30 && bmi > 21 && bmi < 24)
                  label5.Text = "Ideális";
              else if (age >= 40 && bmi > 21 && bmi < 25)
                  label5.Text = "Ideális";
            }
            else // férfiak kor szerint
            {
                if (age < 18 && bmi > 18 && bmi > 20 && bmi < 23)
                    label5.Text = "Ideális";
                else if (age < 18 && age < 30 && bmi > 21 && bmi < 24)
                    label5.Text = "Ideális";
                else if (age < 30 && age < 35 && bmi > 22 && bmi < 24)
                    label5.Text = "Ideális";
                else if (age >= 35 && bmi > 21 && bmi < 25)
                    label5.Text = "Ideális";
            }
        }       
    }
}

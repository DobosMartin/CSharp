using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var ora = 0;
            var perc = 0;
            var most = DateTime.Now;
            var percek = most.Hour * 60 + most.Minute;

            if (percek < 1439) { label8.Text = "23:59"; label7.Text = "Este"; ora = 23; perc = 59; }
            if (percek < 1170) { label8.Text = "19:30"; label7.Text = "14.óra"; ora = 19; perc = 30; }
            if (percek < 1130) { label8.Text = "18:50"; label7.Text = "13.szünet"; ora = 18; perc = 50; }
            if (percek < 1125) { label8.Text = "18:45"; label7.Text = "13.óra"; ora = 18; perc = 45; }
            if (percek < 1085) { label8.Text = "18:05"; label7.Text = "12.szünet"; ora = 18; perc = 5; }
            if (percek < 1080) { label8.Text = "18:00"; label7.Text = "12.óra"; ora = 18; perc = 0; }
            if (percek < 1040) { label8.Text = "17:20"; label7.Text = "11.szünet"; ora = 17; perc = 20; }
            if (percek < 1035) { label8.Text = "17:15"; label7.Text = "11.óra"; ora = 17; perc = 15; }
            if (percek < 995) { label8.Text = "16:35"; label7.Text = "10.szünet"; ora = 16; perc = 35; }
            if (percek < 990) { label8.Text = "16:30"; label7.Text = "10.óra"; ora = 16; perc = 30; }
            if (percek < 950) { label8.Text = "15:50"; label7.Text = "9.szünet"; ora = 15; perc = 50; }
            if (percek < 945) { label8.Text = "15:45"; label7.Text = "9.óra"; ora = 15; perc = 45; }
            if (percek < 905) { label8.Text = "15:05"; label7.Text = "8.szünet"; ora = 15; perc = 5; }
            if (percek < 900) { label8.Text = "15:00"; label7.Text = "8.óra"; ora = 15; perc = 0; }
            if (percek < 860) { label8.Text = "14:20"; label7.Text = "7.szünet"; ora = 14; perc = 20; }
            if (percek < 850) { label8.Text = "14:10"; label7.Text = "7.óra"; ora = 14; perc = 10; }
            if (percek < 810) { label8.Text = "13:30"; label7.Text = "6.szünet"; ora = 13; perc = 30; }
            if (percek < 800) { label8.Text = "13:20"; label7.Text = "6.óra"; ora = 13; perc = 20; }
            if (percek < 760) { label8.Text = "12:40"; label7.Text = "5.szünet"; ora = 12; perc = 40; }
            if (percek < 750) { label8.Text = "12:30"; label7.Text = "5.óra"; ora = 12; perc = 30; }
            if (percek < 705) { label8.Text = "11:45"; label7.Text = "4.szünet"; ora = 11; perc = 45; }
            if (percek < 695) { label8.Text = "11:35"; label7.Text = "4.óra"; ora = 11; perc = 35; }
            if (percek < 650) { label8.Text = "10:50"; label7.Text = "3.szünet"; ora = 10; perc = 50; }
            if (percek < 635) { label8.Text = "10:35"; label7.Text = "3.óra"; ora = 10; perc = 35; }
            if (percek < 590) { label8.Text = "09:50"; label7.Text = "2.szünet"; ora = 9; perc = 50; }
            if (percek < 580) { label8.Text = "09:40"; label7.Text = "2.óra"; ora = 9; perc = 40; }
            if (percek < 535) { label8.Text = "08:55"; label7.Text = "1.szünet"; ora = 8; perc = 55; }
            if (percek < 525) { label8.Text = "08:45"; label7.Text = "1.óra"; ora = 8; perc = 45; }
            if (percek < 480) { label8.Text = "08:00"; label7.Text = "Kezdés"; ora = 8; perc = 0; }

            label6.Text = most.ToString("hh:mm:ss");

            DateTime vege = new DateTime(most.Year, most.Month, most.Day, ora, perc, 0);
            TimeSpan hatra = vege - most;

            label10.Text = string.Format("{0:00}:{1:00}:{2:00}", hatra.Hours, hatra.Minutes, hatra.Seconds);
        }
    }
}

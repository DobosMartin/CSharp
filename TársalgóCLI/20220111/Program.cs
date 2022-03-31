using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220111
{
    class kibe
    {
        public string allapot;
        public int ora, perc, azonosito;
        public kibe(string sor)
        {
            string[]darabok = sor.Split(' ');
            ora = int.Parse(darabok[0]);
            perc = int.Parse(darabok[1]);
            azonosito = int.Parse(darabok[2]);
            allapot = darabok[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("ajto.txt");
            kibe[] lepes = new kibe[beolvas.Length];
            //2.Feladat
            for (int i = 0; i < lepes.Length; i++)
            {
                lepes[i] = new kibe(beolvas[i]);
            }
            int cv = 0;
            while (cv <lepes.Length && lepes[cv].allapot !="be")
            {
                cv++;
            }
            Console.WriteLine("2.Feladat: ");
            Console.WriteLine("Az első belépő azonosítója: {0}",lepes[cv].azonosito);
            cv = lepes.Length - 1;
            while (cv >= 0 && lepes[cv].allapot !="ki")
            {
                cv--;
            }
            Console.WriteLine("Az utolsó kilépő azonosítója: {0}", lepes[cv].azonosito);

            //3.Feladat
            List<int> azonositok = new List<int>();
            for (int i = 0; i < lepes.Length; i++)
            {
                if (!azonositok.Contains(lepes[i].azonosito))
                {
                    azonositok.Add(lepes[i].azonosito);
                }
            }
            azonositok.Sort();
            int[] darabszam = new int[azonositok.Count];
            for (int i = 0; i < lepes.Length; i++)
            {
                int index = azonositok.IndexOf(lepes[i].azonosito);
                darabszam[index]++;
            }
            for (int i = 0; i < azonositok.Count; i++)
            {
                string kiir = azonositok[i] + " " + darabszam[i] + "\n";
                File.AppendAllText("athaladas.txt", kiir);
            }




            Console.ReadLine();
        }
    }
}

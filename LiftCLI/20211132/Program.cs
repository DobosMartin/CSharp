using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211132
{
    class lift
    {
        public string hasznalatiidopont;
        public int sorszam, indulo, celszint;

        public lift(string egysor)
        {
            string[] darabok = egysor.Split(' ');
            hasznalatiidopont = darabok[0];
            sorszam = int.Parse(darabok[1]);
            indulo = int.Parse(darabok[2]);
            celszint = int.Parse(darabok[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("Lift.txt");
            lift[] liftezes = new lift[beolvas.Length];
            for (int i = 0; i < liftezes.Length; i++)
            {
                liftezes[i] = new lift(beolvas[i]);
            }

            //3.Feladat 
            Console.WriteLine("3.feladat: Összes lift használat: {0}", liftezes.Length);

            //4.Feladat
            string[] datumok = new string[liftezes.Length];
            for (int i = 0; i < datumok.Length; i++)
            {
                datumok[i] = liftezes[i].hasznalatiidopont;
            }
            Array.Sort(datumok);
            Console.WriteLine("4.feladat: Időszak: {0} - {1}",datumok[0],datumok[datumok.Length-1]);

            //5.Feladat
            int[] szintek = new int[liftezes.Length];
            for (int i = 0; i < szintek.Length; i++)
            {
                szintek[i] = liftezes[i].celszint;
            }
            Console.WriteLine("5.feladat: Célszint max: {0}",szintek.Max());

            //6.Feladat
            string ksz, csz;
            Console.WriteLine("6.feladat:");
            Console.Write("\tKártya száma: ");
            ksz = Console.ReadLine();
            Console.Write("\tCélszint száma: ");
            csz = Console.ReadLine();
            int kartya, cel;
            try
            {
                kartya = int.Parse(ksz);
                
            }
            catch (Exception)
            {

                kartya = 5;
            }
            try
            {
                cel = int.Parse(csz);
            }
            catch (Exception)
            {

                cel = 5;
            }

            //7.Feladat
            bool vanbenne = false;
            for (int i = 0; i < liftezes.Length; i++)
            {
                if (liftezes[i].sorszam == kartya && liftezes[i].celszint == cel)
                {
                    Console.WriteLine("7.feladat: A {0} kártyával utaztak a(z) {1} emeletre.", kartya,cel);
                    vanbenne = true;
                    break;
                }
            }
            if (vanbenne==false)
            {
                Console.WriteLine("7.feladat: A {0} kártyával nem utaztak a(z) {1} emeletre.", kartya, cel);
            }

            //8.Feladat
            for (int i = 0; i < datumok.Length; i++)
            {
                Console.WriteLine("{0} - x",datumok[0]);
            }



            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
        }
    }
}

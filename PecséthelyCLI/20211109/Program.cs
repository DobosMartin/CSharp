using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211109
{
    class Szakasz
    {
        public string kezdés, vég;
        public double hossz, emelkedés, leejtés;
        public bool pecsét;

        public Szakasz(string egysor)
        {
            string[] darabok = egysor.Split(';');
            kezdés = darabok[0];
            vég = darabok[1];
            hossz = double.Parse(darabok[2]);
            emelkedés = double.Parse(darabok[3]);
            leejtés = double.Parse(darabok[4]);
            if (darabok[5]=="i")
            {
                pecsét = true;
            }
            else
            {
                pecsét = false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("kektura.csv");
            int tengerszint = int.Parse(beolvas[0]);
            Szakasz[] szakaszok = new Szakasz[beolvas.Length - 1];
            for (int i = 0; i < szakaszok.Length; i++)
            {
                szakaszok[i] = new Szakasz(beolvas[i + 1]);
            }
            Console.WriteLine("3. {0} db", szakaszok.Length);

            //4.Feladat
            double teljeshossz = 0;
            foreach (var item in szakaszok)
            {
                teljeshossz = teljeshossz + item.hossz;
            }
            Console.WriteLine("4. {0}", teljeshossz);

            //5.Feladat
            List<double> hosszok = new List<double>();
            foreach (var item in szakaszok)
            {
                hosszok.Add(item.hossz);
            }
            double minhossz = hosszok.Min();
            int minindex = hosszok.IndexOf(minhossz);
            Console.WriteLine("5.");
            Console.WriteLine("\t{0}", szakaszok[minindex].kezdés);
            Console.WriteLine("\t{0}", szakaszok[minindex].vég);
            Console.WriteLine("\t{0} km", szakaszok[minindex].hossz);

            //7.Feladat
            Console.WriteLine("7.");
            bool vane = false;
            foreach (var item in szakaszok)
            {
                if (HianyosNev(item.vég,item.pecsét))
                {
                    Console.WriteLine(item.vég);
                    vane = true;
                }
            }
            if (vane==false)
            {
                Console.WriteLine("Nincs hiányos állomásnév.");
            }
           




            Console.ReadLine();
        }
        //6.Feladat
        static bool HianyosNev(string vég, bool pecsét)
        {
            if (pecsét && !vég.Contains("pecsetelohely"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

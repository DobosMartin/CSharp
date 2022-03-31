using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220301
{
    class Varazslo
    {
        public double Atlag { get; private set; }
        public string Tanonc { get; private set; }
        public string Trollkodas { get; private set; }
        public string Igyekezettan { get; private set; }
        public int Asztronomia { get; private set; }
        public int Szammisztika { get; private set; }
        public int Magiatortenet { get; private set; }
        public int Bubajtan { get; private set; }
        public string Gyogynovenytan { get; private set; }
        public string Joslastan { get; private set; }
        public int Atvaltozastan { get; private set; }
        public int Bajitaltan { get; private set; }
        public int Mugliismeret { get; private set; }
        public int Sotetvarazslatokkivedese { get; private set; }
        public int Runaismeret { get; private set; }
        public int Legendaslenyekgondozasa { get; private set; }
        public int Kipurcantan { get; private set; }
        public int Logastan { get; private set; }
        public List<int> Naplo = new List<int>();
        public Varazslo(string sor)
        {
            string[] s = sor.Split(';');
            Tanonc = s[0];
            Trollkodas = s[1];
            Igyekezettan = s[2];
            Asztronomia = Convert.ToInt32(s[3]);
            Szammisztika = Convert.ToInt32(s[4]);
            Magiatortenet = Convert.ToInt32(s[5]);
            Bubajtan = Convert.ToInt32(s[6]);
            Gyogynovenytan = s[7];
            Joslastan = s[8];
            Atvaltozastan = Convert.ToInt32(s[9]);
            Bajitaltan = Convert.ToInt32(s[10]);
            Mugliismeret = Convert.ToInt32(s[11]);
            Sotetvarazslatokkivedese = Convert.ToInt32(s[12]);
            Runaismeret = Convert.ToInt32(s[13]);
            Legendaslenyekgondozasa = Convert.ToInt32(s[14]);
            Kipurcantan = Convert.ToInt32(s[15]);
            Logastan = Convert.ToInt32(s[16]);
            int k = 11;
            if (s[7] == "FM")
            {
                s[7] = "-1";
                k--;
            }
            else if (s[7] == "")
            {
                s[7] = "0";
            }
            if (s[8] == "")
            {
                s[8] = "0";
            }
            for (int i = 3; i < 15; i++)
            {
                Naplo.Add(Convert.ToInt32(s[i]));
            }
            Atlag = (double)Naplo.Sum() / k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("tanoncok.txt");
            Varazslo[] naplo = new Varazslo[beolvas.Length];
            for (int i = 0; i < beolvas.Length; i++)
            {
                naplo[i] = new Varazslo(beolvas[i]);
            }
            Console.WriteLine("5.Feladat: {0} tanonc jár a varázslóiskolába.", beolvas.Length);

            Console.WriteLine("6.Feladat: Trollok:");
            for (int i = 0; i < naplo.Length; i++)
            {
                if (naplo[i].Trollkodas == "troll")
                {
                        Console.WriteLine(naplo[i].Tanonc);
                }
            }

            
            Console.Write("7.Feladat: Kérek egy tanonc nevet! ");
            string nev;
            nev = Console.ReadLine();
            bool vanbenne = false;
            for (int i = 0; i < naplo.Length; i++)
            {
               
                if (nev == naplo[i].Tanonc)
                {
                    Console.WriteLine(naplo[i].Atlag);
                    vanbenne = true;
                }
               
            }
            if (vanbenne==false)
            {
                Console.WriteLine("A megadott tanonc nem varázsolhat!");
            }


            Console.WriteLine("enter");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Karácsony_Díszek_CLI
{
    class NapiMunka
    {
        public static int KeszultDb { get; private set; }
        public int Nap { get; private set; }
        public int HarangKesz { get; private set; }
        public int HarangEladott { get; private set; }
        public int AngyalkaKesz { get; private set; }
        public int AngyalkaEladott { get; private set; }
        public int FenyofaKesz { get; private set; }
        public int FenyofaEladott { get; private set; }

        public NapiMunka(string sor)
        {
            string[] s = sor.Split(';');
            Nap = Convert.ToInt32(s[0]);
            HarangKesz = Convert.ToInt32(s[1]);
            HarangEladott = Convert.ToInt32(s[2]);
            AngyalkaKesz = Convert.ToInt32(s[3]);
            AngyalkaEladott = Convert.ToInt32(s[4]);
            FenyofaKesz = Convert.ToInt32(s[5]);
            FenyofaEladott = Convert.ToInt32(s[6]);

            NapiMunka.KeszultDb += HarangKesz + AngyalkaKesz + FenyofaKesz;
        }

        public int NapiBevetel()
        {
            return -(HarangEladott * 1000 + AngyalkaEladott * 1350 + FenyofaEladott * 1500);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //3.Feladat 
            string[] beolvas = File.ReadAllLines("diszek.txt");
            NapiMunka[] tarol = new NapiMunka[beolvas.Length];
            for (int i = 0; i < tarol.Length; i++)
            {
                tarol[i] = new NapiMunka(beolvas[i]);
            }

            //4.Feladat
            for (int i = 0; i < tarol[1].Nap; i++)
            {
                int osszes = tarol[1].HarangKesz + tarol[3].AngyalkaKesz + tarol[5].FenyofaKesz;
                Console.WriteLine("{0}", osszes);
            }
           

            Console.ReadLine();
        }
    }
}

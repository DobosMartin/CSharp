using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20201123_oktatas
{
    class Ev
    {
        public string tanev;
        public int knappali, kfelnott, fnappali, fnemnappali, osszes, felso;
        public Ev(string egysor)
        {
            string[] darabok = egysor.Split('*');
            tanev = darabok[0];
            knappali = int.Parse(darabok[1]);
            kfelnott = int.Parse(darabok[2]);
            fnappali = int.Parse(darabok[3]);
            fnemnappali = int.Parse(darabok[4]);
            osszes = knappali + kfelnott + fnappali + fnemnappali;
            felso = fnappali + fnemnappali;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("statisztika.txt");
            Ev[] evek = new Ev[beolvas.Length];
            for (int i = 0; i < evek.Length; i++)
            {
                evek[i] = new Ev(beolvas[i]);
            }
            Console.WriteLine("1. Feladat");
            Console.WriteLine("\tA statisztika {0} tanév adatát tartalmazza.", evek.Length);

            Console.WriteLine("2. Feladat");
            int db_2 = 0;
            for (int i = 0; i < evek.Length; i++)
            {
                if (evek[i].kfelnott<7000)
                {
                    db_2++;
                }
            }
            Console.WriteLine("\t{0}", db_2);

            Console.WriteLine("3. Feladat");
            for (int i = 1; i < evek.Length; i++)
            {
                if (evek[i].knappali<evek[i-1].knappali)
                {
                    Console.WriteLine(evek[i].tanev);
                }
            }
            int ossz_4 = 0;
            for (int i = evek.Length-10; i < evek.Length; i++)
            {
                ossz_4 = ossz_4 + evek[i].felso;
            }
            Console.WriteLine("4. Feladat");
            Console.WriteLine("\t{0}", ossz_4/10);

            Console.WriteLine("Nyomj egy entert");
            Console.ReadKey();
        }
    }
}

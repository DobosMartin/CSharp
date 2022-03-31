using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat21();
            //feladat22();
            //feladat23();
            //feladat24();
            //feladat25();
            feladat26();
            //feladat27();
            //feladat28();
            //feladat29();
            //feladat30();
            Console.ReadLine();
        }
        static void feladat21()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int a = 1; a < 16; a++)
                {
                    Console.Write("{0}*{1}={2} ",i,a, i*a);
                    Console.WriteLine();
                }
            }
        }
        static void feladat22()
        {

        }
        static void feladat24()
        {
            Console.WriteLine("Írj be egy számot aztán Enter");
            int i = int.Parse(Console.ReadLine());
            while (i!=0)
            {
                Console.WriteLine("Nem jó a szám, kérek másika");
                i = int.Parse(Console.ReadLine());
            }
            if (i==0)
            {
                Console.WriteLine("Talált");
            }
        }
        static void feladat25()
        {
            Console.WriteLine("Írj be egy számot aztán Enter");
            int i = int.Parse(Console.ReadLine());
            while (i<0)
            {
                Console.WriteLine("Nem jó!");
               i = int.Parse(Console.ReadLine());
            }
            if (i>0)
            {
                Console.WriteLine("Ez már jobb!");
            }
        }
        static void feladat26()
        {
            List<int> osszeg = new List<int>();
            Console.WriteLine("Írj be egy számot aztán Enter");
            int i = Convert.ToInt32(Console.ReadLine());

            while (i<10)
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            if (i>10)
            {
                osszeg.Add(i);
                Console.WriteLine("Az összegük: ",osszeg.Sum()); 
            }

        }
    }
}

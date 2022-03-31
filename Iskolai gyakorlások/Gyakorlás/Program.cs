using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _20191210  //összegmegszámlálás
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Hány számot tároljunk el?
             2. tömb létrehozása
             3. feltölteni a tömböt
             4. tömb elemeit összeadjuk
             5. kiírjuk az összeget
              */
            // 1.
            int szam;
            Console.WriteLine("Hány számot adjunk össze?");
            szam = int.Parse(Console.ReadLine());
            // 2.
            int[] tomb = new int[szam];
            // 3.
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(50, 81);
            }
            // 4.
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg = osszeg + tomb[i];
            }
            // 5.
            Console.WriteLine("A számok összege: {0}", osszeg);


            Console.WriteLine("----------------------------Hőmérséklet----------------------");
            double[] hom = new double[7];
            for (int i = 0; i < hom.Length; i++)
            {
                hom[i] = rnd.Next(0, 11);
            }
            double ho = 0;
            for (int i = 0; i < hom.Length; i++)
            {
                ho = ho + hom[i];
            }
            Console.WriteLine("az átlagos hőmérséklet: {0:0.00}", ho / 7);
            Console.WriteLine("---------------------Autó pálya------------------");
            int[] seb = new int[20];
            for (int i = 0; i < seb.Length; i++)
            {
                seb[i] = rnd.Next(80, 131);
            }
            double au = 0;
            for (int i = 0; i < seb.Length; i++)
            {
                au = au + seb[i];
            }
            Console.WriteLine("Az átlag sebesség {0:0.00}", au / 20);
            Console.WriteLine("Enter!!4!!");
            Console.ReadKey();
        }
    }
}
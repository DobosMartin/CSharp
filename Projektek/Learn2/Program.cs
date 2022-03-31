using System;

namespace Learn2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write <-> Console.WriteLine
            Console.Write("Helló világ!");
            Console.WriteLine("helló világ!");
            //operátorok, egyéb értékadó operátorok
            //+, -, *, /, %
            double a = 8;
            int b = 3;
            a = a + 2;
            Console.WriteLine(a);
            //adatbekérés
            int szam = Convert.ToInt32(Console.ReadLine());
            szam += 10;
            Console.WriteLine("Bekért eredmény: " +  szam);
            Console.ReadKey();
            //itt a bekért eredményhez még hozzá ad tizet
        }
    }
}

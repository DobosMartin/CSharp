using System;

namespace Learn3.part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //logikai operátorok >, <, <=, >=, !, ==
            //if - else, else if
            //több if egymásban 
            //az and és az or
            Console.Write("Páros vagy páratlan: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Páratlan");
            }
            Console.ReadKey();
            //Ha ezt írjuk a trueból false lesz és fordítva-->(!(szam % 2 == 0))
        }
    }
}

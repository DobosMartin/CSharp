using System;

namespace Learn3
{
    class Program
    {
        static void Main(string[] args)
        {
            //logikai operátorok >, <, <=, >=, !, ==
            //if - else, else if
            //több if egymásban 
            //az and és az or
            Console.Write("Adjon meg egy számot(pozitív-e): ");
            int szam = int.Parse(Console.ReadLine());
            bool pelda = szam > 0;
            if (szam > 0)
            {
                //igaz ág
                Console.WriteLine("Ügyes,a szám pozitív");
            }
            else
            {
                //hamis ág
                Console.WriteLine("Pancser,ez negatív szám");
            }
            Console.ReadKey();
            //Bekérünk egy számot és ha pozitív akkor megdicsér 
        }
    }
}

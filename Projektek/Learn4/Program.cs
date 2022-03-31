using System;

namespace Learn4
{
    class Program
    {
        static void Main(string[] args)
        {
            //randolomás
            Random r = new Random();
            //vektorok
            int[] vektor = new int[6];
            vektor[0] = 20;
            vektor[3] = 12;
            for (int i=0; i<vektor.Length; i++)
            {
                vektor[i] = r.Next(200, 400) ;
            }
            {
                foreach (int item in vektor)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}

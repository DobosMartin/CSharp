using System;

namespace Learn5
{
    class Program
    {
        static void Main(string[] args)
        {
            //elágazások: switch
            //Nehezebb
            int szam = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            /* if (szam == 5)
             {
                 Console.WriteLine("Jeles");
             }
             else if  (szam == 4)
             {
                 Console.WriteLine("jó");
             }
             else if (szam == 3)
             {
                 Console.WriteLine("Közepes");
             }
             else if (szam == 2)
             {
                 Console.WriteLine("elégséges");
             }
             else if (szam == 1)
             {
                 Console.WriteLine("elégtelen");
             }
             */
            //könnyebb
            /*switch (szam)
            {
                case 5:
                    Console.WriteLine("jeles"); 
                    break;
                case 4:
                    Console.WriteLine("jó");
                    break;
                case 3:
                    Console.WriteLine("közepes");
                    break;
                case 2:
                    Console.WriteLine("elégséges");
                    break;
                case 1:
                    Console.WriteLine("elégtelen");
                    break;
                default:
                    Console.WriteLine("Ilyen osztályzat nincs");
                    break;
                    
                }
            */
            //szöveggel
            switch (str)
            {
                case "alma":
                    Console.WriteLine("Gyümölcs");
                    break;
                case "asztal":
                    Console.WriteLine("tárgy");
                    break;
                default:
                    Console.WriteLine("ilyen nincs a programban");
                    break;
            }
            Console.ReadKey();
        }
    }
}

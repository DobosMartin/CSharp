using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            //feladat11();
            //feladat12();
            //feladat13();
            feladat14();
            //feladat15();
            //feladat16();
            //feladat17();
            //feladat18();
            //feladat19();
            //feladat20();
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("A");
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("B");
            for (int i = 0; i < 21; i++)
            {
                Console.Write(" " + i);
            }
        }
        static void feladat2()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.Write(" " + i);
            }
        }
        static void feladat3()
        {
            Console.WriteLine("A");
            for (int i = 1; i <30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("B");
            for (int i = 1; i < 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
            }
        }
        static void feladat4()
        {
            Console.WriteLine("Írj be egy pozitív egész számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam ; i++)
            {
                Console.Write(" " + i);
            }


        }
        static void feladat5()
        {
            Console.WriteLine("Írj be egy pozitív egész számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat6()
        {
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
        static void feladat7()
        {
            for (int i = 100; i < 401; i++)
			{
                if (i % 4==0)
	            {
                    Console.WriteLine(i);
	            }
			}
        }
        static void feladat8()
        {
            for (int i = 30; i < 101; i=i+9)
			{
                Console.WriteLine(i);
			}
        }
        static void feladat9()
        {
            for (int i = 150; i > 41; i=i-12)
			{
                Console.WriteLine(i);
			}
        }
        static void feladat10()
        {
            for (int i = 100; i > -100; i=i-1)
			{
                if (i % 9 == 0)
	            {
                    Console.WriteLine(i);
	            }
			}
        }
        static void feladat11()
        {
            for (int i = -30; i < 31; i=i+5)
			{
                Console.WriteLine(i);
			}
        }
        static void feladat12()
        {
            for (int  i = 3;  i < 3*18 ; i=i+3)
			{
                Console.WriteLine(i);
			}
        }
        static void feladat13()
        {
            for (int i = 1; i < 17; i++)
			{
                Console.WriteLine(Math.Pow(2, i));
			}
        }
        static void feladat14()
        {
            for (int i = 1; i < 26; i=i*7)
			{
             Console.WriteLine(Math.Pow(i*7));   
                if (i % 4 == 0)
	            {
                    Console.WriteLine(i);
	            }
			}
        }
        static void feladat15()
        {
            for (int i = 1; i < 145; i++)
			{
                if (i % 2 == 0)
	            {
                    Console.WriteLine(i);
	            }
			}
        }
        static void feladat16()
        {
            Console.WriteLine("Írj be egy pozitív egész számot majd enter:");
            int osztando = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
			{
                if (osztando % 2 == 0)
	            {
                
	            }
		    }
        }
    }
}

using System;
using System.Text;
using System.IO;

namespace Learn7
{
    class Program
    {
        static void Main(string[] args)

            //olvas
        {
            StreamReader olvas = new StreamReader("proba.txt", Encoding.Default);
            string szoveg;
            while(!olvas.EndOfStream)//for (int i = 1; i <= 3; i++)
            {
                szoveg = olvas.ReadLine();
                Console.WriteLine(szoveg);
            }
            olvas.Close();
            Console.ReadLine();
           
        }
    }
}

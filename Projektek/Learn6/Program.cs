using System;
using System.IO;

namespace Learn6
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream
            
            Random rnd = new Random();

            FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
                
            for (int i = 1; i < 2; ++i)
                sw.WriteLine(rnd.Next(1,3));
           









            sw.Close();
            fs.Close();

            Console.ReadKey();
           
        }
    }
}

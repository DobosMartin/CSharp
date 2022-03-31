using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unió tétel");
            int[] a = { 3, 5, 8, 4 };
            int[] b = { 2, 1, 7, 9 };
            int[] c = new int[18];
            int i, j, k;
            int n = a.Length, m = b.Length;
            //Unió tétel
            for (i = 0; i < n; i++)
                c[i] = a[i];
            k = n;
            for (j = 0; j < m; j++)
            {
                i = 0;
                while (i < n && b[j] != a[i])
                    i++;
                if (i >= n)
                {
                    c[k] = b[j];
                    k++;
                }
            }
            //Az a tömb kiíratása
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            //A b tömb kiíratása
            for (i = 0; i < m; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine();
            //A c eredménytömb kiíratása
            for (i = 0; i < k; i++)
                Console.Write(c[i] + " ");
            Console.WriteLine();

            Console.ReadLine();
            Console.WriteLine("Enter");
        }
    }
}

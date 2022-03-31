using System;

namespace Learn4part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Randomolás
            Random r = new Random();
            //mátrixok
            int[,] matrix = new int[10, 16];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(100);
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }
            //egyéb szabályos, négyzetes tömbök
            //mutatóvektorok
            //string 
        }
    }
}

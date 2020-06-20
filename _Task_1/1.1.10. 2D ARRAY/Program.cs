using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._10._2D_ARRAY
{
    class Program
    {
        static void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write("{0}, ", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); ++i)
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[i, j] = random.Next(0, 100);
                }
            Console.WriteLine("initial array:");
            printArray(array);
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

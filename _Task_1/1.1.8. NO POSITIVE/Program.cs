using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._8.NO_POSITIVE
{
    class Program
    {
        static void printArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i)
                for (int j = 0; j < arr.GetLength(1); ++j)
                    for (int k = 0; k < arr.GetLength(2); ++k)
                    {
                        Console.Write("{0}, ", arr[i, j, k]);
                    }
        }

        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 2, 2];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); ++i)
                for (int j = 0; j < arr.GetLength(1); ++j)
                    for (int k = 0; k < arr.GetLength(2); ++k)
                    {
                        arr[i, j, k] = random.Next(-100, 100);

                    }
            Console.WriteLine("initial array:");
            printArray(arr);
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); ++i)
                for (int j = 0; j < arr.GetLength(1); ++j)
                    for (int k = 0; k < arr.GetLength(2); ++k)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
            Console.WriteLine("change array:");
            printArray(arr);
            Console.ReadLine();
        }
    }
}

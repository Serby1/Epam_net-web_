using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._9.NON_NEGATIVE_SUM
{
    class Program
    {
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("{0}, ", array[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(-100, 100);
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            printArray(arr);
            Console.WriteLine();
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}

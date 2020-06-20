using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._7_ARRAY_PROCESSING
{
    class Program
    {
        static void MAX(int[] array)
        {
            int max = -2147483648;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("MAX={0}", max);
        }

        static void MIN(int[] array)
        {
            int min = 2147483647;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("MIN={0}", min);
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("{0}, ", array[i]);
            }
        }


        static public void sort(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                heap(array, n, i);
            for (int i = n - 1; i >= 0; i--)
            {

                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heap(array, i, 0);
            }
        }

        static void heap(int[] array, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < n && array[l] > array[largest])
                largest = l;

            if (r < n && array[r] > array[largest])
                largest = r;

            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heap(array, n, largest);
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }
            Console.WriteLine("Содержание массива:");
            printArray(array);
            Console.WriteLine();
            MAX(array);
            MIN(array);
            Console.WriteLine("Отсортированный массив:");
            sort(array);
            printArray(array);
            Console.ReadLine();
        }
    }
}

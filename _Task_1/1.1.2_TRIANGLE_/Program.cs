using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._2_TRIANGLE_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N;
            Console.WriteLine("Enter N:");
            string input = Console.ReadLine();
            bool result = uint.TryParse(input, out N);
            if (result)
            { }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            for (int i = 1; i <= N; ++i)
            {
                int k = 0;
                while (k != i)
                {
                    Console.Write('*');
                    ++k;
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}

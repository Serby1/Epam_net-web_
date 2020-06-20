using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._5_SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1000;
            int sum = 0;
            for (int i = 0; i < m; ++i)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

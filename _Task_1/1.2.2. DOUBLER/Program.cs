using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._2.DOUBLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("IN 1: ");
            string str1 = Console.ReadLine();
            Console.Write("IN 2: ");
            string str2 = Console.ReadLine();
            string strOut = "";
            for (int i = 0; i < str1.Length; ++i)
            {
                if (str2.Contains(str1[i]))
                {
                    strOut = strOut + str1[i] + str1[i];
                }
                else
                {
                    strOut += str1[i];
                }
            }
            Console.WriteLine("OUT: {0}", strOut);
            Console.ReadLine();
        }
    }
}

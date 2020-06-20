using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._4.VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("IN: ");
            string str1 = " " + Console.ReadLine();
            char[] separators = new char[str1.Length / 3];
            int j = 0;
            for (int i = 0; i < str1.Length; ++i)//заполнение массива разделителей из введеной строки, чтоб не потерять знаки при выводе
            {
                if (str1[i] == '.' || str1[i] == '!' || str1[i] == '?')
                {
                    separators[j] = str1[i];
                    ++j;
                }
            }
            string[] sentenceArray = str1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string strOut = "";

            for (int i = 0; i < sentenceArray.Length; ++i)
            {
                string str2 = sentenceArray[i];
                strOut = str2.ToUpper()[1].ToString();
                str2 = str2.Substring(2);
                strOut += str2;
                Console.Write("{0}{1} ", strOut, separators[i]);
            }

            Console.ReadLine();

        }
    }
}

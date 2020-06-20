using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3.LOWERCASE
{
    class Program
    {
        static void Main(string[] args)//выполнил с дополнительным заданием
        {
            Console.Write("IN: ");
            string str1 = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '!', '?', '»', '«', ':' };
            string[] wordsArray = str1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;
            for (int i = 0; i < wordsArray.Length; ++i)
            {
                string str2 = wordsArray[i];
                if (str2[0] == str2.ToLower()[0])
                {
                    ++k;
                }

            }
            Console.WriteLine("OUT: {0}", k);
            Console.ReadLine();
        }
    }
}

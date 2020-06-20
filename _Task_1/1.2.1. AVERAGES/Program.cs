using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._1.AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '!', '?', '»', '«', ':' };
            string[] wordsArray = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int sumLetters = 0;
            int sumWords = wordsArray.Length;
            for (int i = 0; i < wordsArray.Length; ++i)
            {
                sumLetters += wordsArray[i].Length;
            }
            Console.WriteLine((double)sumLetters / sumWords);  //выведет дробный результат
            Console.ReadLine();

        }
    }
}

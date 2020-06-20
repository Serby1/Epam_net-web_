using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._6.FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "None";
            string input = "";
            while (input != "4")
            {
                Console.Write("Параметры надписи: {0}\n", str);
                if (str == "None")
                {
                    str = "";
                }
                Console.Write("Введите:\n\t1: bold\n\t2: italic\n\t3: underline\n\t4: EXIT\n ");
                input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        if (str.Contains("Bold"))
                        {
                            str = str.Replace("Bold, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Bold, ");
                        }
                        break;
                    case "2":
                        if (str.Contains("Italic"))
                        {
                            str = str.Replace("Italic, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Italic, ");
                        }
                        break;
                    case "3":
                        if (str.Contains("Underline"))
                        {
                            str = str.Replace("Underline, ", "");
                        }
                        else
                        {
                            str = str.Insert(str.Length, "Underline, ");
                        }
                        break;
                    default:
                        input = "4";
                        break;
                }
                if (str == "")
                {
                    str = "None";
                }

            }


        }
    }
}

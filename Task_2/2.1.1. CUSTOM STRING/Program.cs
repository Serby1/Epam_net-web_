using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.CUSTOM_STRING
{
    class MyString
    {
        private char[] chars;

        //конструкторы класса
        public MyString(string str)
        {
            chars = str.ToCharArray();
        }
        public MyString(char[] chars)
        {
            this.chars = chars;
        }

        //метод для получения длины массива(строки)
        public int Length() => chars.Length;

        //сравнение по длине строк
        public int CompareTo(MyString str)
        {
            if (Length() > str.Length())
            {
                return 1;
            }
            else if (Length() < str.Length())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //посимвольное сравнение равных по длине строк
        public int Compare(MyString str)
        {
            if (Length() == str.Length())
            {
                for (int i = 0; i < Length(); ++i)
                {
                    if (chars[i] > str[i])
                    {
                        return 1;
                    }
                    else if (chars[i] < str[i])
                    {
                        return -1;
                    }
                }
                return 0;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Strings are not equal!");
            }
        }

        public MyString Concatenation(MyString str)
        {

            int resultLength = Length() + str.Length();
            char[] resultChars = new char[resultLength];
            for (int i = 0; i < Length(); ++i)
            {
                resultChars[i] = chars[i];
            }
            for (int i = Length(); i < resultLength; ++i)
            {
                resultChars[i] = str[i - Length()];
            }
            return new MyString(resultChars);
        }

        public int Find(char symbol)
        {
            for (int i = 0; i < Length(); ++i)
            {
                if (chars[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Length(); ++i)
            {
                str += chars[i];
            }
            return str;
        }

        //добавил от себя

        public MyString Reverse()
        {
            char[] reverseArray = new char[Length()];
            for (int i = 0; i < Length(); ++i)
            {
                reverseArray[i] = chars[Length() - i - 1];
            }
            return new MyString(reverseArray);
        }

        //индексатор 
        public char this[int index]
        {
            get
            {
                if (index < chars.Length && index > -1)
                {
                    return chars[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
            set
            {
                if (index < chars.Length && index > -1)
                {
                    chars[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

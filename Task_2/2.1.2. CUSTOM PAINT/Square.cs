using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Square : Rectangle
    {
        public Square(double centerX, double centerY, Line a)
        {
            X = centerX;
            Y = centerY;
            A = a;
            B = a;
        }

        public override void Show()
        {
            Console.WriteLine($"\nType figure: Square" +
                $"\ncenter: {X}, {Y}" +
                $"\nseid A: {A.Length()}" +
                $"\nseid B: {B.Length()}" +
                $"\narea: {Area()}" +
                $"\nperimeter: {Perimeter()}\n");
        }
    }
}

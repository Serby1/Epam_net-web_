using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Triangle : Figure
    {
        private Line A;
        private Line B;
        private Line C;

        public Triangle(double centerX, double centerY, Line a, Line b, Line c) 
        {
            X = centerX;
            Y = centerY;
            A = a;
            B = b;
            C = c;
        }
        public override double Area() => Math.Sqrt((Perimeter() / 2) * (Perimeter() / 2 - A.Length()) * (Perimeter() / 2 - B.Length()) * (Perimeter() / 2 - C.Length()));

        public double Perimeter() => A.Length() + B.Length() + C.Length();
       


        public override void Show()
        {
            Console.WriteLine($"\nType figure: Triangle" +
                $"\ncenter: {X}, {Y}" +
                $"\nseid A: {A.Length()}" +
                $"\nseid B: {B.Length()}" +
                $"\nseid C: {C.Length()}" +
                $"\narea: {Area()}" +
                $"\nperimeter: {Perimeter()}\n");
        }
    }
}

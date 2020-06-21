using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Rectangle : Figure
    {
        protected Line A;
        protected Line B;

        public Rectangle(double centerX, double centerY, Line a, Line b)
        {
            X = centerX;
            Y = centerY;
            A = a;
            B = b;
        }

        public Rectangle()
        {
            X = 0;
            Y = 0;
            A = new Line(0, 0, 0, 0);
            B = new Line(0, 0, 0, 0);
        }

        public override double Area() => A.Length() * B.Length();

        public double Perimeter() => 2*(A.Length() + B.Length());

        public override void Show()
        {
            Console.WriteLine("\nType figure: Rectangle " +
                "\ncenter: {0}, {1}" +
                "\nseid A: {2}" +
                "\nseid B: {3}" +
                "\narea: {4}" +
                "\nperimeter: {5}\n", X, Y, A.Length(),B.Length(), Area(), Perimeter());
        }
    }
}

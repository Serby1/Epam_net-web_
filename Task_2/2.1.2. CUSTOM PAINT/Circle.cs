using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Circle : Figure
    {
        protected double radius;

        public Circle(double x, double y, double radius) 
        {
            X = x;
            Y = y;
            this.radius = radius;
        }
        public override double Area() => Math.PI * Math.Pow(radius, 2);

        public double LangthCircle() => 2 * Math.PI * radius;

        public override void Show()
        {
            Console.WriteLine("\nType figure: Circle \ncenter: {0}, {1} " +
                "\nradius: {2} \narea: {3} \nlength circle: {4}" +
                "\n", X, Y, radius, Area(), LangthCircle());
        }

       
    }
}

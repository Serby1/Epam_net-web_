using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    class Ring : Circle
    {
        protected double innerRadius;

        public Ring(double x, double y, double radius, double innerRadius) : base(x, y, radius)
        {
            this.innerRadius = innerRadius;
        }

        public override double Area() => Math.PI * (Math.Pow(radius, 2)- Math.Pow(innerRadius, 2));

        public  double SumLangthCircle() => 2 * Math.PI * (radius+innerRadius);

        public override void Show()
        {
            Console.WriteLine("\nType figure: Ring \ncenter: {0}, {1} " +
                "\nouter radius: {2} \ninner radius: {3} " +
                "\narea: {4} \nsum length circle: {4}\n", X, Y, radius, innerRadius, Area(), SumLangthCircle());
        }
    }
}

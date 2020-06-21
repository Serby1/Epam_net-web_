using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2._1._2.CUSTOM_PAINT
{
    class Line:Figure
    {
        private double bigenX;
        private double bigenY;
        private double endX;
        private double endY;
       
        public Line(double bigenX, double bigenY, double endX, double endY)
        {
            this.bigenX = bigenX;
            this.bigenY = bigenY;
            this.endX = endX;
            this.endY = endY;
        }

        public double Length() => Math.Sqrt(Math.Pow(bigenX - endX, 2) + Math.Pow(bigenY - endY, 2));

        public override void Show()
        {
            Console.WriteLine("\nType figure: Line" +
                "\nLength: {0}\n", Length());
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

    }
}

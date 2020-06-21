using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2.CUSTOM_PAINT
{
    abstract class Figure
    {
        //координаты центра
        protected double X, Y;

        // метод для вывода информации о фигуре
        public abstract void Show();

        //метод считающий площадь фигуры
        public abstract double Area();
    }
}

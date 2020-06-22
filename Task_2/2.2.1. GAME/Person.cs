using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    abstract class Person
    {
        //координаты отвечающие за позицию персонажей
        protected int positionX;
        protected int positionY;

        //метод описывающий движение персонажей
        public abstract void Move(int height, int width);
    }
}

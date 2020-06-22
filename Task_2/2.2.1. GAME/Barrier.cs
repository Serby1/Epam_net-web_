using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    class Barrier:Object
    {
        //свойства для получения координат препятсвия
        public int ShowPositionX => positionX;
        public int ShowPositionY => positionY;

        //конструткор создающий препятствия на карте
        public Barrier(int wight, int height)
        {
            this.wigth = wight;
            this.height = height;
            AddObject();
        }

        //метод создающий препятсвие
        public override void AddObject()
        {
            positionX = rnd.Next(1, wigth - 2);
            positionY = rnd.Next(1, height - 2);
        }
    }
}

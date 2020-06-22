using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    class Bonus:Object
    {
        //свойства для получения координат бонуса
        public int ShowPositionX => positionX;
        public int ShowPositionY => positionY;

        //конструткор создающий бонус 
        public Bonus(int wight, int height)
        {
            this.wigth = wight;
            this.height = height;
            AddObject();    
        }

        //метод при вызове конструктора создающий бонус, затем меняющий местоположение бонуса, после того как его подобрал игрок
        public override void AddObject()
        {
            positionX = rnd.Next(1, wigth - 2);
            positionY = rnd.Next(1, height - 2);
        }

        //проверка для отрисовки бонуса
        public bool Draw(int i, int j)
        {
            if (i == positionY && j == positionX)
            {
                return true;
            }
            return false;
        }

        //метод который отслеживает поднимание бонусов
        public void TakeBonus(Player player, Bonus bonus)
        {
            if (player.ShowPositionX == bonus.ShowPositionX && player.ShowPositionY == bonus.ShowPositionY)
            {
                Console.Write(" ");
                player.Score += 10;
                bonus.AddObject();
            }
        }
    }
}

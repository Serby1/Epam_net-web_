using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
	class Player : Person
	{
		protected int hp;

		//public eDirection dir = 0;

		public int Score { get; set; } = 0;
		public int ShowPositionX => positionX;
		public int ShowPositionY => positionY;
		public int ShowHP => hp;

		//создание персонажа в дефолтной точке
		public Player()
        {
            positionX = 3;
            positionY = 3;
            hp = 3;
        }

        //создание персонажа в выбранной пользователем точке
        public Player(int posX, int posY)
        {
            positionX = posX;
            positionY = posY;
            hp = 3;
        }

        public void TakeDamage()
        {
            hp--;
        }

        ////пытался сделать отклик на нажатие через enum
        //public enum eDirection 
        //{
        //    STOP=0,
        //    LEFT,
        //    RIGHT,
        //    UP,
        //    DOWN
        //};

		//метод отвечающий за управление персонажем
		public override void Move(int width, int height)
		{
			var key = Console.ReadKey();
			switch (key.Key)
            {
				case ConsoleKey.UpArrow:
					{
						if (positionY > 0)
						{
							positionY--;
						}
					}
					break;
				case ConsoleKey.DownArrow:
					{
						if (positionY < height-1)
						{
							positionY++;
						}
					}
					break;
				case ConsoleKey.LeftArrow:
					{
						if (positionX > 0)
						{
							positionX--;
						}
					}
					break;
				case ConsoleKey.RightArrow:
					{
						if (positionX < width-2)
						{
							positionX++;
						}
					}
					break;
				default:
					break;
            }
			
		}

		//проверка для отрисовки персонажа
		public bool Draw(int i, int j)
		{
			if (i == positionY && j == positionX)
			{
				return true;
			}
			return false;
		}
	}
}

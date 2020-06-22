using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2._2._1.GAME
{
    class Map
    {
        //отрисовка карты
        public void Draw(int width, int height,  Player player, Bonus bonus)
        {
            
            Console.Clear(); 
            for (int i = 0; i < width+1; ++i)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    if (player.Draw(i, j))
                    {
                        Console.Write("0");
                    }
                    else if (bonus.Draw(i, j))
                    {
                        Console.Write("B");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

            for (int i = 0; i < width+1; ++i)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            Console.Write($"\nScore: {player.Score}");
        }      
    }
}

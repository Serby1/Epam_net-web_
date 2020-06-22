using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width= 40;
            const int height = 20;
            Console.CursorVisible = false;
            Map map = new Map();
            Player player = new Player();
            Bonus bonus = new Bonus(width,height);
            while (player.ShowHP > 0)
            {
                bonus.TakeBonus(player, bonus);
                map.Draw(width, height, player, bonus);
                player.Move(width,height);
                
            }
            
        }
    }
}

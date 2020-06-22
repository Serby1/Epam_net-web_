using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    abstract class Object
    {
        protected int positionX;
        protected int positionY;
        protected int wigth;
        protected int height;
        protected Random rnd = new Random();

        public abstract void AddObject();
    }
}

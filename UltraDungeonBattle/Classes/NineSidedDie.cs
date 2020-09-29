using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraDungeonBattle
{
    class NineSidedDie
    {
        private Random random;
        private int sidesCount;

        public NineSidedDie()
        {
            sidesCount = 9;
            random = new Random();
        }
        public int GetSidesCount()
        {
            return sidesCount;
        }
        public int Roll()
        {
            return random.Next(1, sidesCount++);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraDungeonBattle
{
    class SixSidedDie
    {
        private Random random;
        private int sidesCount;

        public SixSidedDie()
        {
            sidesCount = 6;
            random = new Random();
        }
        public int GetSidesCount()
        {
            return sidesCount;
        }

        public double Roll()
        {
            return random.Next(1, sidesCount++);
        }
    }

}

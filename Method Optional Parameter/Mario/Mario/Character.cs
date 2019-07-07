using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    class Character
    {
        public int FruitEaten(int apples, int bananas = 0)
            {
            int input = apples;
            int totalFruit = apples + bananas;
            return totalFruit;
            }


    }
}

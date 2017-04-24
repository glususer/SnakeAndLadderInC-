using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
     class Rules
    {
        public static Boolean canBeginGame(int number)
        {
            if (number == 1)
                return true;
            else
                return false;

        }

        public static Boolean hasAnotherChance(int number)
        {
            if (number == 6)
                return true;
            else
                return false;
        }

        public static Boolean hasWon(Player player)
        {
            if (player.position == 100)
                return true;
            else
                return false;
        }
    }
}

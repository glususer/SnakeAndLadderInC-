using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Player
    {
        String name;
        Boolean isReady = false;
        public Player(string name)
        {
            this.name = name;
        }

        public int position { get; private set; }

        public void getReady()
        {
            this.isReady = true;
        }

        public Boolean hasAnotherChance(int number)
        {
            if (number == 6)
                return true;
            else
                return false;
        }

        public Boolean canMove(int number)
        {
            if (100 - this.position > number)
                return true;
            else
                return false;
        }

        public Boolean canBeginGame(int number)
        {
            if (Rules.canBeginGame(number))
                return true;
            else
                return false;
        }

        public Boolean hasWonGame()
        {
            if (position == 100)
                return true;
            else
                return false;
        }

        public void updatePosition(int number)
        {
            position += number;
        }

        public Boolean canPlay(int number)
        {
            if ((canBeginGame(number) || isReady) && (position <= 100))
                return true;
            else
                return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class EntityGenerator
    {   
        public static Entity[] generate(int noOfEntity, string name)
        {
            if (name == "snake")
            {
                Entity[] snake = new Entity[noOfEntity];
                int end = 0;

                for (int i = 0; i < noOfEntity; i++)
                {
                    Random r = new Random();
                    int start = r.Next(end + 1, end + 5);
                    int diff = r.Next(10, 20);
                    end = start + diff;
                    snake[i] = new Entity(new Location(end, start));
                }
                return snake;

            }
            else
            {
                Entity[] ladder = new Entity[noOfEntity];
                int end = 0;

                for (int i = 0; i < noOfEntity; i++)
                {
                    Random r = new Random();
                    int start = r.Next(end + 1, end + 5);
                    int diff = r.Next(10, 20);
                    end = start + diff;
                    ladder[i] = new Entity(new Location(start, end));
                }
                return ladder;
            }
        }
    }

   
}

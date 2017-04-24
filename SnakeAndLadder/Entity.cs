using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Entity
    {
        public Location loc;
        public Entity(Location loc)
        {
            this.loc = loc;
        }
        public Location getLocation()
        {
            return loc;
        }
    }
}

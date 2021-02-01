using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player
    {
        public Player(int health, int x, int y)
        {
            Health = health;
            X = x;
            Y = y;
        }

        public int Health { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

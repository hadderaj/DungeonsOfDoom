using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Monster
    {
        public Monster(int health)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
}

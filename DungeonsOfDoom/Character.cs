using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public int Health { get; set; }
        public int Dmg { get; set; }

        public Character(int health, int dmg)
        {
            Health = health;
            Dmg = dmg;
        }

    }
}

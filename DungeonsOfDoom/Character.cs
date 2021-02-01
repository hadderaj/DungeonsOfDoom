using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public int Health { get; set; }
        public int Dmg { get; set; }

        public Character(int health, int baseDmg)
        {
            Health = health;
            Dmg = baseDmg;
        }
        public virtual void Attack(Character victim)
        {
            victim.Health -= Dmg;
        }





    }
}

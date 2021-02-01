using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Goblin:Monster

    {
        public Goblin() : base(10, 3, "Goblin")
        {

        }

        public override void Attack(Character victim)
        {
            if (Health <5)
            {
                victim.Health = Dmg *2;
            } else base.Attack(victim);
            
        }
    }
}

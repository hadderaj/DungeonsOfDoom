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

        public override int Attack(Character target)
        {
            if (Health < 5)
            {
                target.Health -= Dmg * 2;
                return (Dmg * 2);
            }
            else
            {
                base.Attack(target);
                return Dmg;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Vampire : Monster
    {
        public Vampire() : base(15, 7, "Vampire")
        {

        }

        public override int Attack(Character target)
        {
            target.Health -= Dmg +1;
            Health++;
            return Dmg + 1;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public int Health { get; set; }
        //{
        //    get  {};
        //    set
        //    {
        //        if (value < 0)
        //            Health = 0;
        //        else
        //            Health = value;
        //    }

        //}
        public int Dmg { get; set; }

        public Character(int health, int baseDmg)
        {
            Health = health;
            Dmg = baseDmg;
        }
        public virtual int Attack(Character target)
        {
            target.Health -= Dmg;
            return Dmg;

        }





    }
}

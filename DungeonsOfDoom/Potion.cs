using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public Potion(string name, int healthMod) : base(name)
        {
            HealthMod = healthMod;
        }
        public int HealthMod { get; set; }
    }

}

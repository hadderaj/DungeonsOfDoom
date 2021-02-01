using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Weapon : Item
    {
        public Weapon(string name, int dmgMod) : base(name)
        {
            DmgMod = dmgMod;
        }
        public int DmgMod { get; set; }
    }
}

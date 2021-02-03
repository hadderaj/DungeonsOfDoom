using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item
    {
        public int HealthMod { get; set; }
        public int DmgMod { get; set; }
        public string Name { get; set; }
        public string ItemModifier { get; set; }


        public Item(string name, int healthMod, int dmgMod)
        {
            Name = name;
            HealthMod = healthMod;
            DmgMod = dmgMod;
        }


        public virtual void ItemEffect(Player player)
        {
            player.Health += HealthMod;
            player.Dmg += DmgMod;
        }




        //Skapa methoder abstraka/virituella
    }
}

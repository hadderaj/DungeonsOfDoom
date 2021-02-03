using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public Potion(string name, int healthMod) : base(name, healthMod,0) // ska in med health ++
        {
        }

        public override void ItemEffect(Player player)
        {
            base.ItemEffect(player);
            ItemModifier = $"You found a {this.Name} and gained {this.HealthMod} healthpoints";
        }

    }

}

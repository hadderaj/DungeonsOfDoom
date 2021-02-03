using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Weapon : Item
    {
        public Weapon(string name, int dmgMod) : base(name, 0, dmgMod) // Skapa subklasser till vapen
        {


        }
        public override void ItemEffect(Player player)
        {
            base.ItemEffect(player);
            ItemModifier = $"You found a {this.Name} and gained {this.DmgMod} dmg";
            player.backpack.Clear();
        }
    }
}

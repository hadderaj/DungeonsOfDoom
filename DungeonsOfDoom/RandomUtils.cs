using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    static class RandomUtils
    {
        static Random rand = new Random();
        public static int Fifty50()
        {
            return rand.Next(2);
        }
        public static int PlayerAttack(Player player)
        {
            int newDmg = rand.Next(player.Dmg * 80, player.Dmg * 120);
            return newDmg / 100;
        }
    }
}

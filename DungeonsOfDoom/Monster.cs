using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Monster:Character
    {
        
        

        public Monster(int health, int baseDmg, string name): base(health, baseDmg)
        {
            Name = name;
        }
        public string Name { get; set; }
        



    }
}

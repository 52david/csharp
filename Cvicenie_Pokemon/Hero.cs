using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pokemon
{
    public class Hero
    {
        public int Health { get; set; }
        public int Health_Max { get; set; }
        public int Damage { get; set; }
        public int Energia { get; set; }

        public Hero(int health, int health_Max, int damage, int energia)
        {
            Health = health;
            Health_Max = health_Max;
            Damage = damage;
            Energia = energia;
        }
    }
}

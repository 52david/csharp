using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    public class Hero
    {
        public string Name { get; set; } = "Arnost"; // hero name
        public int HP { get; set; } = 100;      //health points
        public int DMG { get; set; } = 10;     // damage
        public int ENG { get; set; } = 100; //Energia
        public int Armor { get; set; } = 15; //armor

        public bool HeroAttack (Monster monster)
        {
            if (ENG - 20 >= 0)
            {
                ENG = ENG - 20;              // za jeden utok odcita 20 energie
                monster.HP = monster.HP - DMG; //zrani monstra
                return true;
            }
            else
            {
                ENG = ENG + 20; // ak nema dost eng tak si ju trochu obnovi
                return false;
            }

        }
    }
}

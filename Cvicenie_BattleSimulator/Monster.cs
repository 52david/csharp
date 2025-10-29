﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    public class Monster
    {
        public string RaceType { get; set; } //Monster race type
        public int HP { get; set; }      //health points
        public int DMG { get; set; }     // damage

        public Monster(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }
        public void MonsterAttack(Hero hero)
        {
            hero.HP = hero.HP - DMG;
        }
    }
}

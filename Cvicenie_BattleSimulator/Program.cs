using System.ComponentModel.Design;

namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 3);

            int heroHPafterFight = ourHero.HP - monster1.DMG;
            ourHero.HP = heroHPafterFight;

            while (true)
            {
                // hero dostal utok od monstra
                monster1.MonsterAttack(ourHero);
                // monster dostal utok od hero
                bool wasAttak = ourHero.HeroAttack(monster1);
                if (wasAttak)
                {
                    Console.WriteLine(monster1.HP);
                }
                else
                {
                    Console.WriteLine("---Not enough Energy to attack!Restoring energy...");
                    Console.WriteLine("HERO: energy " + ourHero.ENG);
                }


                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                }
                if (monster1.HP <= 0)
                {
                    Console.WriteLine("Monster is dead");
                    break;
                }





            }
        }
    }
}

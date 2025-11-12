using System.ComponentModel.Design;

namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 3);
            Monster monster2 = new ("Gnom", 150, 3);
            Monster monster3 = new Monster("Chmo", 150, 3);

            List<Monster> monsters = new List<Monster>();
            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);


            int heroHPafterFight = ourHero.HP - monster1.DMG;
            ourHero.HP = heroHPafterFight;

            while (true)
            {
                int pocetMonstier = monsters.Count;
                int ktora = r.Next(0, pocetMonstier);
                monsters[ktora].MonsterAttack(ourHero); //random monster utoci na hrdinu
                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Tvoj hrdina zomrel");
                    break;
                }

                /*// hero dostal utok od monstra
                monster1.MonsterAttack(ourHero); // monster1 utoci na hrdinu
                monster2.MonsterAttack(ourHero);
                monster3.MonsterAttack(ourHero);*/
                // monster dostal utok od hero
                ourHero.HeroAttack(monsters[ktora]);
                if (monsters[ktora].HP <= 0)
                {
                    Console.WriteLine("Zabil si monstra");
                    monsters.RemoveAt(ktora);
                }

                if (monsters.Count == 0)
                {
                    Console.WriteLine("Zabil si vsetkych monstrov");
                    break;
                }
                Console.WriteLine("Tvoj hrdina ma teraz:" + ourHero.HP);

                foreach (Monster monster in monsters)
                {
                    Console.WriteLine(monster.RaceType + " ma " + monster.HP);
                }

                /*bool wasAttack = ourHero.HeroAttack(monsters[ktora]); // energia hrdina
                if (wasAttack)
                {
                    Console.WriteLine("MONSTER:HP " + monsters[ktora].HP);
                }
                else
                {
                    Console.WriteLine("---Not enough energy to attack! Restoring energy...");
                    Console.WriteLine("HERO:energy " + ourHero.ENG);
                }*/


                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Hero is dead");
                    break;
                }
                if (monsters[ktora].HP <= 0)
                {
                    Console.WriteLine("Monster is dead");
                    break;
                }

            }
        }
    }
}

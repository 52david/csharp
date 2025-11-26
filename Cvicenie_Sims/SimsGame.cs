using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Sims
{
    public class SimsGame
    {
        public Player MyPlayer {  get; set; } = new Player();
        public void StartGame()
        {
            bool isRunning = true;
            while (isRunning)
            {
                MyPlayer.Starving();
                if (MyPlayer.Health <= 0)
                {
                    Console.WriteLine("Game over");
                    isRunning = false;
                }
                Console.WriteLine(MyPlayer.Hunger + " " + MyPlayer.Health + " " + MyPlayer.Thirst); 

                MyPlayer.Thirsty();
                if (MyPlayer.Health <= 0)
                {
                    Console.WriteLine("Game over");
                    isRunning = false;
                }
                int cena = 5;
                int money = 20;
                int day = 0;
                day++;
                Console.ReadLine();
                Console.WriteLine("Koniec dna " + day);

                Console.WriteLine("Peniaze " + money);
                Console.WriteLine("Menu");
                Console.WriteLine("1 Pracovat");
                Console.WriteLine("2 Kupit Jedlo");
                Console.WriteLine("3 Kupit Napitie");
                
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                }
            }
        }
    }
}

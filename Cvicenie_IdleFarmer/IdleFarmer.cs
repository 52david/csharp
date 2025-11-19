using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_IdleFarmer
{
    public class IdleFarmer
    {
        public int Cena { get; set; } = 5;
        public int Money { get; set; } = 20;
        public Random RandomGenerator { get; set; } = new Random();
        public int Day {  get; set; } 
        public List<Plant> Field {  get; set; } = new List<Plant>();
        public List<Plant> Storage { get; set; } = new List<Plant>();


        public void StartGame()
        {
            Plant cibula = new Plant ("Cibula",5, 10);
            Plant pomaranc = new Plant("Pomaranc", 40, 9);
            Plant jahoda = new Plant("Jahoda", 20, 5);

            Field.Add(cibula);
            Field.Add(pomaranc);
            Field.Add(jahoda);

            while (true)
            {
                Day++;

                foreach (Plant plant in Field)
                {
                    plant.TimeInGround++;
                }

                foreach (Plant plant in Field)
                {
                    Console.WriteLine(plant);
                }

                List<Plant> harvesterPlants = new List<Plant>();

                foreach (Plant plant in Field)
                {
                    if (plant.TimeInGround >= plant.TimeForHarvest)
                    {
                        Console.WriteLine("Rastlina uz vyrastla " + plant);
                        harvesterPlants.Add(plant);
                    }
                }

                foreach (Plant plant in harvesterPlants)
                {
                    Field.Remove(plant);
                    Storage.Add(plant);
                }

                Console.WriteLine("Koniec dna " + Day);

                Console.WriteLine("Peniaze " + Money);
                Console.WriteLine("Menu");
                Console.WriteLine("Enter Novy den ");
                Console.WriteLine("1 Pridanie rastlinky " + Cena + "e)");
                Console.WriteLine("2 Sklad");
                Console.WriteLine("3 Predat sklad");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        int doba = RandomGenerator.Next(10, 30);
                        int cena = RandomGenerator.Next(5, 15);
                        if (Money - Cena >= 0)
                        {
                            Plant newPlant = new Plant("Zelenina", doba, cena); // DOROBIT TOTO
                            Field.Add(newPlant);
                        }
                        break;
                    case "2":
                        foreach (Plant plant in Storage)
                        {
                            Console.WriteLine(plant);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        int sum = 0;
                        foreach (Plant plant in Storage)
                        {
                            Money += plant.Price;
                        }
                        Money += sum = Storage.Count;
                        Storage.Clear();
                        break;
                    default:
                        break;
                }
                Console.Clear();

            }
        }
    }
}

using System.Numerics;

namespace Cvicenie_GameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = LootGenerator.GetRandomLoot();

            /*Item currentBest = items[0];         //stary sposob
            foreach (Item item in items)
            {
                if (item.Price > currentBest.Price)
                {
                    currentBest = item;
                }
            }
            Console.WriteLine(currentBest);*/

            //Novy sposob
            Item worst = items.MinBy(item => item.Price);
            Console.WriteLine(worst);

            Item best = items.MaxBy(item => item.Price);
            Console.WriteLine(best);

            List<Item> orderByPrice = items.OrderBy(vec => vec.Price).ToList();

            foreach (Item item in orderByPrice)
            {
                Console.WriteLine(item);
            }

            List<Item> orderByPriceNajdrahsi = items.OrderByDescending(vec => vec.Price).ToList();
            Console.WriteLine("Toto je najdrahsi vec: " + orderByPriceNajdrahsi[0]);

            List<Item> itemUnder1000 = items.Where(vec => vec.Price <= 1000).ToList();
            Console.WriteLine("Pocet itemov pod 1000 " + itemUnder1000.Count);

            List<Item> item500to1000 = items.Where(vec => vec.Price >= 1000 && vec.Price >=500 ).ToList();
            Console.WriteLine("Pocet itemov od 500 po 1000" + item500to1000.Count);
        }
    }
    
}

using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoiffe.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool");
            Console.WriteLine("Write 'help' to list available commands");
            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(">Available Coffee shop commands:");
                    foreach (var coffeshop in coffeeShops)
                    {
                            Console.WriteLine($">" + coffeshop.Location);
                    }
                }
            }
        }
    }
}

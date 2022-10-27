using System;

namespace BaggageInfo
{
    internal class Program
    {
        enum BagTypes
        {
            Bag1,
            Bag2,
            ComputerBag,
            HandBag
        }
        static void Main(string[] args)
        {
            var BagTypes = Enum.GetValues(typeof(BagTypes));
            var totalWeight = 0m;
            Console.WriteLine("Where did you flew from?");
            var origin = Console.ReadLine();
            foreach (var bag in BagTypes)
            {
                Console.WriteLine($"Did you have {bag} luggage option?(Y/N)");
                if (Console.ReadLine().ToLower().Contains("y"))
                {
                    Console.WriteLine("How much do they weigh (kg)?");
                    if (decimal.TryParse(Console.ReadLine(), out var weight))
                    {
                        totalWeight += weight;
                    }
                }

            }
            Console.WriteLine($"I flew from {origin} with {totalWeight:n} kg of luggage");
            Console.ReadLine();
        }
    }
}

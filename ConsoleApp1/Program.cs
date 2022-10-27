using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        enum bag_types
        {
            bag1,
            bag2,
            computerbag,
            handbag
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the location from where the user is flew from");
            var location = Console.ReadLine();
            var bag_types = Enum.GetValues(typeof(bag_types));
            var total_weight = 0m;
            foreach (var bag_type in bag_types)
            {
                Console.WriteLine($"do you have {bag_type} option(put Y for Yes/put N for No)?");
                if (Console.ReadLine().ToLower().Contains("y"))
                {
                    Console.WriteLine($"please enter the weight of {bag_type}");
                    if (decimal.TryParse(Console.ReadLine(), out var weight))
                    {
                        total_weight += weight;
                    }
                }
            }
            Console.WriteLine($"I flew from {location} with {total_weight}kg of luggage");
            Console.ReadKey();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Country you arrived from : ");
            var country = Console.ReadLine();

            Console.Write("Number of Bag(s) you have : ");
            int.TryParse(Console.ReadLine(), out var bagCount);

            Console.Write("Total weight of lugguage(s) : ");
            float.TryParse(Console.ReadLine(), out var lugguageweight);

            Console.WriteLine($"I flew from {country} having { bagCount} bags with average weight of { lugguageweight:n2} Kg.");
            Console.ReadLine();
        }
    }
}

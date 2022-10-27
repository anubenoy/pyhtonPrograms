using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportKiosk
{
    class Program
    {
        enum Bags
        {
            Bag1, Bag2, ComputerBag, Handbag
        }
        static void Main(string[] args)
        {
            float sumWeight = 0;
            Console.Write("Enter the country that you have arrived from ? : ");
            var country = Console.ReadLine();

            foreach (Bags bag in Enum.GetValues(typeof(Bags)))
            {
                Console.WriteLine($"\n--------- {bag} ---------");
                Console.Write($"Do you have {bag} (Yes/No) ? : ");

                if ("y" == Console.ReadLine().ToLower()[0].ToString())
                {
                    float weight; 
                    do
                    {
                        Console.Write($"weight of {bag}? : ");
                    } while (!float.TryParse(Console.ReadLine(), out weight));
                    sumWeight += weight;
                }
            }
            Console.WriteLine($"\nI flew from {country} with {sumWeight:n2} kg of luggage");
            Console.ReadKey();
        }
    }
}

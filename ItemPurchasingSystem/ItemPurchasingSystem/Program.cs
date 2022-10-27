using System;
using System.Collections.Generic;

namespace ItemPurchasingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ItemDataModel> itemData = new List<ItemDataModel>();
            var itemKey = 0;
            var itemName = "";
            var itemCount = 0;
            var i = 0;
            var choice = "n";
            var subtotal = 0.0;

            Console.WriteLine("------- Select one of options --------\n");
            do
            {
                ItemDataModel item = new ItemDataModel();
                do
                {
                    if (i != 0) Console.WriteLine("\n\nEntered value option is incorrect, Please try again! \n\n ");
                    Console.WriteLine("1. Apple \t$0.78 \n2. Orange \t$0.99\n3. Lemon \t$0.66\n4. Lime \t$0.58 \n5. Grape \t$0.95\n6. Banana \t$0.29\n\nChoose one number : ");
                    int.TryParse(Console.ReadLine().Trim(), out int itemKeyTemp);
                    i = 1;
                    itemKey = itemKeyTemp;
                } while (itemKey == 0 || itemKey > 6);
                i = 0;

                do
                {
                    if (i != 0) Console.WriteLine("\nEntered value option is incorrect, Please try again! \n");
                    Console.WriteLine("How many items : ");
                    int.TryParse(Console.ReadLine().Trim(), out int itemCountTemp);
                    i = 1;
                    itemCount = itemCountTemp;
                } while (itemCount == 0);
                i = 0;

                item.itemName = item.getDataValue(itemKey);
                item.itemCount = itemCount;
                itemData.Add(item);
                Console.WriteLine("Do you want to exit ? (Y|N) : ");
                choice = Console.ReadLine().Trim();
                subtotal += item.getItemPrice(item.itemName) * itemCount;
            } while (choice.ToLower() != "y");

            Console.WriteLine($"\nNumber of items purchased : \t{itemData.Count}");
            Console.WriteLine($"All item cost subtotal : \t${subtotal:n2}");
            Console.WriteLine($"HST amount : \t\t\t${subtotal*0.13:n2}");
            Console.WriteLine($"\n\nGrand total : \t\t\t${(subtotal * 0.13)+subtotal:n2}");
            Console.ReadLine();
        }
    }
    public class ItemDataModel
    {
        public String itemName { set; get; }
        public int itemCount { set; get; }

        public String getDataValue(int data)
        {
            switch (data)
            {
                case 1:
                    return "Apple";
                case 2:
                    return "Orange";
                case 3:
                    return "Lemon";
                case 4:
                    return "Lime";
                case 5:
                    return "Grape";
                case 6:
                    return "Banana";
                default:
                    return "Apple";
            }
        }
        public Double getItemPrice(string data)
        {
            switch (data)
            {
                case "Apple":
                    return 0.78;
                case "Orange":
                    return 0.99;
                case "Lemon":
                    return 0.66;
                case "Lime":
                    return 0.58 ;
                case "Grape":
                    return 0.95;
                case "Banana":
                    return 0.29;
                default:
                    return 0.00;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace BillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductDetails> itemData = new List<ProductDetails>();

            var error = "Enter a valid ";
            var i = 0;
            var choice = "" ;
            var mainchoice = "";
            var itemPayMethod = "cash";
            var flag = true;

            bool IsValidPayMethod(string data)
            {
                switch (data.ToLower())
                {
                    case "credit card":
                        return true;
                    case "debit card":
                        return true;
                    case "cash":
                        return true;
                    default:
                        return false;
                }
            }

            do
            {
                ProductDetails item = new ProductDetails();
                do
                {
                    Console.WriteLine($"{(i == 0 ? "" : error)}Purchased Item : ");
                    var itemName = Console.ReadLine().Trim();
                    i = 1;
                    if (!item.IsValidPurchase(itemName))
                    {
                        Console.WriteLine("Entered value is incorrect, Do you want to exit ? (Y|N): ");
                        choice = Console.ReadLine();
                        if (choice.ToLower() == "y") flag = false;
                        else flag = true;
                    }
                    else
                    {
                        item.itemName = itemName;
                        item.itemPrice = item.getItemPrice(itemName);
                        choice = "y";
                    }
                } while (choice.ToLower() != "y");

                if (flag == false) break;
                i = 0;

                do
                {
                    Console.WriteLine($"{(i == 0 ? "" : error)}item weight : ");
                    int.TryParse(Console.ReadLine().Trim(), out int itemWeight);
                    i = 1;
                    if (itemWeight <= 0)
                    {
                        Console.WriteLine("Entered value is incorrect, Do you want to exit ? (Y|N): ");
                        choice = Console.ReadLine();
                        if (choice.ToLower() == "y") flag = false;
                        else flag = true;
                    }
                    else
                    {
                        item.itemKG = itemWeight;
                        choice = "y";
                    }
                } while (choice.ToLower() != "y");

                i = 0;
                if (flag == false) break;
                itemData.Add(item);

                Console.WriteLine("Do you have any more data ? (Y|N) : ");
                mainchoice = Console.ReadLine().Trim();
            } while (mainchoice.ToLower() == "y");

            i = 0;
            do
            {
                Console.WriteLine($"{(i == 0 ? "" : error)}method of payment : ");
                var itemMethodPayment = Console.ReadLine().Trim();
                i = 1;
                if (!IsValidPayMethod(itemMethodPayment))
                {
                    Console.WriteLine("Entered value is incorrect, Do you want to exit ? (Y|N) : ");
                    choice = Console.ReadLine();
                    if (choice.ToLower() == "y") flag = false;
                    else flag = true;
                }
                else
                {
                    itemPayMethod = itemMethodPayment;
                    choice = "y";
                }
            } while (choice.ToLower() != "y");

            printData();
            Console.ReadLine();

            void printData()
            {
                var basePrice = 0.0;
                var discoucntAmount = 0.0;
                var payFee = 0.0;
                Console.WriteLine("\n\nItem Name \t\t KG \t Discount \t price \t Amount");
                Console.WriteLine("--------- \t\t -- \t -------- \t ----- \t ------");
                foreach (var data in itemData)
                {
                    var discount = 0;
                    if (data.itemKG > 20)
                    {
                        discoucntAmount += data.itemKG * (data.itemPrice * 0.10);
                        discount = 10;
                    }
                    basePrice += data.itemKG * data.itemPrice;
                    Console.WriteLine($"{data.itemName}\t\t\t {data.itemKG} \t {discount}% \t\t {data.itemPrice} \t {data.itemKG * data.itemPrice:n2}");
                }
                if (itemPayMethod == "credit card") payFee = ((basePrice - discoucntAmount) * 0.02);

                Console.WriteLine($"\n\nThe base price : \t{basePrice:n2}");
                Console.WriteLine($"The discount amount : \t{discoucntAmount:n2}");
                Console.WriteLine($"Payment fee amount : \t{payFee:n2}");

                var subPrice = basePrice - discoucntAmount + payFee;

                Console.WriteLine($"\nSubtotal Price : \t{subPrice:n2}");
                Console.WriteLine($"HST Amount : \t\t{subPrice*0.13:n2}");
                Console.WriteLine($"\nGrand Total : \t\t{(subPrice * 0.13)+subPrice:n2}");

            }
        }
    }
    public class ProductDetails
    {
        public string itemName { set; get; }
        public int itemKG { set; get; }
        public double itemPrice { set; get; }

        public bool IsValidPurchase(string data) {
            switch (data.ToLower())
            {
                case "apples":
                    return true;
                case "oranges":
                    return true;
                case "lemons":
                    return true;
                case "limes":
                    return true;
                default:
                    return false;
            }
        }

        public double getItemPrice(string data)
        {
            switch (data.ToLower())
            {
                case "apples":
                    return 0.79;
                case "oranges":
                    return 1.19;
                case "lemons":
                    return 0.39;
                case "limes":
                    return 0.99;
                default:
                    return 0.00;
            }
        }
    }
}

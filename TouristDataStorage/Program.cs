using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristDataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tourist> touristData = new List<Tourist>();
            bool isDuplicatePassport(String data)
            {
                foreach (var x in touristData)
                    if (x.userPassport.ToLower() == data.ToLower()) return true;
                return false;
            }

            string errorString = " a valid ";
            string choice;
            do
            {
                Tourist UserData = new Tourist();

                // ------------------------ input part ------------------------
                var i = 0;
                do
                {
                    Console.WriteLine($"Enter{(i == 0 ? " " : errorString)}User Full Name : ");
                    UserData.userName = Console.ReadLine().Trim();
                    i++;
                } while (!UserData.IsValidString(UserData.userName));

                i = 0;
                do
                {
                    Console.WriteLine($"Enter{(i == 0 ? " " : errorString)}user city Name : ");
                    UserData.userCity = Console.ReadLine().Trim();
                    i++;
                } while (!UserData.IsValidString(UserData.userCity));

                i = 0;
                do
                {
                    Console.WriteLine($"Enter{(i == 0 ? " " : errorString)}user passport Number : ");
                    UserData.userPassport = Console.ReadLine().Trim();
                    i++;
                } while (isDuplicatePassport(UserData.userPassport) || !UserData.isValidPassportNumber(UserData.userPassport));

                i = 0;
                do
                {
                    Console.WriteLine($"Enter{(i == 0 ? " " : errorString)}number of bags : ");
                    UserData.userBags = Console.ReadLine().Trim();
                    i++;
                } while (!UserData.isValidNumber(UserData.userBags));

                i = 0;
                do
                {
                    Console.WriteLine($"Enter{(i == 0 ? " " : errorString)}total weight of bags : ");
                    UserData.userBagsWeight = Console.ReadLine().Trim();
                    i++;
                } while (!UserData.isValidNumber(UserData.userBagsWeight));

                touristData.Add(UserData);
                Console.WriteLine("Any more user (Y|N) : ");
                choice = Console.ReadLine();

            } while (choice.ToLower() == "y");

            // ------------------------ output part ------------------------

            Console.WriteLine("--------- Passengers -----------");
            foreach (var user in touristData)
            {
                int.TryParse(user.userBagsWeight, out int bagWeiht);
                int.TryParse(user.userBags, out int numBags);
                Console.WriteLine($"{user.userName}, XXX{user.userPassport.Substring(3)}, {user.userBags} Bags, {bagWeiht / numBags} lbs");
            }
            Console.ReadKey();
        }
    }
    public class Tourist
    {
        public string userName { set; get; }
        public string userCity { set; get; }
        public string userPassport { set; get; }
        public string userBags { set; get; }
        public string userBagsWeight { set; get; }

        public bool IsValidString(String data)
        {
            if (data.Length == 0) return false;
            foreach (var x in data)
                if (x.ToString() != " ")
                    if (!Char.IsLetter(x)) return false;
            return true;
        }

        public bool isValidPassportNumber(String data)
        {
            if (data.Length != 8) return false;
            else
            {
                foreach (var x in data.Substring(0, 2))
                    if (!char.IsLetter(x)) return false;
                foreach (var x in data.Substring(2))
                    if (!char.IsDigit(x)) return false;
            }
            return true;
        }

        public bool isValidNumber(String data)
        {
            if (data.Length == 0) return false;
            foreach (var x in data)
                if (!char.IsDigit(x)) return false;
            return true;
        }
    }
}

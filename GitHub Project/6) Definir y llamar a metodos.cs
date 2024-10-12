using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
namespace HelperMethods2
{
    class Program
    {
        static void Main(string[] args)
        {

            //before using helper methods

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            char[] fNameArray = fName.ToCharArray();
            Array.Reverse(fNameArray);

            char[] lNameArray = lName.ToCharArray();
            Array.Reverse(lNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach( char item in fNameArray)
            {
                result += item;
            }

            foreach(char item in lNameArray)
            {
                result += item;
            }

            foreach(char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            Console.ReadLine();

        }
    }
}
namespace HelperMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            // using helper methods

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("What city are you in? ");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] msgArray = message.ToCharArray();
            Array.Reverse(msgArray);
            return String.Concat(msgArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName,string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2})", reversedFirstName, reversedLastName, reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
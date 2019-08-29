using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myVariable = "Hello World!";
            string myStringVariable;
            myStringVariable = "steve";
            Console.WriteLine(myStringVariable);

            int myIntVariable;
            myIntVariable = 123;

            decimal myDecimalVariable;
            myDecimalVariable = 123.123m; //m means it's a decimal
            Console.WriteLine(myDecimalVariable);

            //DateTime myDateTime;
            var myDateTime = new DateTime();
            Console.WriteLine(myDateTime);

            bool myBool = false;

            if (myBool)
            {
                Console.WriteLine("We'll never hit this code.");
            }

            switch (myIntVariable)
            {
                case 1:
                    Console.WriteLine("It's 1");
                    break;
                case 2:
                    Console.WriteLine("It's 2");
                    break;
                default:
                    Console.WriteLine("It's not 1 or two");
                    break;
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"We're on iteration {i}");
            }

            var myThing = new { Stuff = "steve" }; //read only way to declaring an object

            //Lists are the jack-of-all-trades collection type
            List<string> myStrings = new List<string>();
            myStrings.Add("stuff1");
            myStrings.Add("stuff2");
            myStrings.Insert(1,"stuff3");
            myStrings.Remove("stuff2");
            myStrings.RemoveAt(1);

            foreach(var myString in myStrings)
            {
                Console.WriteLine(myString);
            }

            //Console.WriteLine(myVariable);

            // **NOT HELLO, WORLD EXERCISE BELOW**

            Console.WriteLine("Welcome to Bangazon!");
            Console.ReadKey(); // What happens if you run the app without this line?

            // DateTime is the type of the purchaseDate variable
            DateTime purchaseDate = DateTime.Now;
            /*
               string is the type of the lastName variable
               It tells the complier that the lastName variable
               can ONLY hold a string value.
            */
            string lastName = "Smith";
            /*
                C# now supports implicitly typing of a variable.
                The type of the variable will be determined by the compiler at compile time.
             */
            var firstName = "Bill";

            Console.WriteLine($"{firstName} {lastName} visited on {purchaseDate}");
            Console.ReadLine(); // <-- Stops the program waiting for user input.

            // Not only do you have to say what type the variable is, you also have to
            // instantiate that exact same type of object on assignment.  This may seem
            // redundant, but it's part of the C# language compiler's type checking constraints.
            string[] products = new string[] { "Motorcycle", "Sofa", "Sandals", "Omega Watch", "iPhone" };

            // This syntax should look very similar to what you did with Array.forEach in JS.
            // However, once again you have to explicitly say what type of variable product is.
            // Since the products array holds strings, then its type must be string.
            foreach (string product in products)
            {
                if (product.Length > 5)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}

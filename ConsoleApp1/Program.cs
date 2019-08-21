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

            int myIntVariable;
            myIntVariable = 123;

            decimal myDecimalVariable;
            myDecimalVariable = 123.123m; //m means it's a decimal

            //DateTime myDateTime;
            var myDateTime = new DateTime();

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
        }
    }
}

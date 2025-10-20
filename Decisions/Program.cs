// Created by following this video:
// [x] https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/the-if-decision-statement

// not required anymore...
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bob's Big Giveaway");
            // Console.Write("Choose a door: 1, 2, or 3: ");
            // string? userValue = Console.ReadLine();
            //
            // string? message;
            // if (userValue == "1") message = "You won a new car!";
            // else if (userValue == "2") message = "You won a new car!";
            // else if (userValue == "3") message = "You won a new cat!";
            // else
            // {
            //     message = "Sorry, I didn't understand that. Try again.";
            //     message += "You lose!";
            // }
            
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string? userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            // Console.Write("You won a  ");
            // Console.Write(message);
            // Console.Write(".");
           
            // Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, You won a {1}.", userValue, message);
            
            Console.ReadLine();
        }
    }
}


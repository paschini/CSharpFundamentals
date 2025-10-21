// Created by following this video:
// [x] https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/defining-and-calling-methods

// not required anymore...
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;


namespace HelperMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The new Game");
        
        Console.WriteLine("What's your first name?");
        string? firstName = Console.ReadLine() ?? "";
        
        Console.WriteLine("What's your last name?");
        string? lastName = Console.ReadLine() ?? "";
        
        Console.Write("In what city were you born?");
        string? city = Console.ReadLine() ?? "";
        //
        // char[] firstNameArray = firstName.ToCharArray();
        // Array.Reverse(firstNameArray);
        //
        // char[] lastNameArray = lastName.ToCharArray();
        // Array.Reverse(lastNameArray);
        //
        // char[] cityArray = city.ToCharArray();
        // Array.Reverse(cityArray);
        //
        // // string result = "";
        // // foreach (char item in firstNameArray)
        // // {
        // //     result += item;
        // // }
        // string result = "";
        // result += " " + new string(firstNameArray.Select(c => c).ToArray()); // LINQ, same as the above commented-out code
        // result += " " + new string(lastNameArray.Select(c => c).ToArray()); 
        // result += " " + new string(cityArray.Select(c => c).ToArray());
        //
        // Console.WriteLine($"Results: {result}");
        
        // refactored with the new ReverseString method
        // Console.Write("Results: ");
        // ännu mer refactoring xD
        // string reversedFirstName = ReverseString(firstName);
        // string reversedLastName = ReverseString(lastName);
        // string reversedCity = ReverseString(city);
        
        Console.Write("Results: ");
        DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
        
        DisplayResult(ReverseString($"{ReverseString(firstName)} {ReverseString(lastName)} {ReverseString(city)}"));
        
        Console.ReadLine();
    }

    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        // refactoring more.. xD
        // Console.Write(" " + new string(messageArray.Select(c => c).ToArray()));
        // return new string(messageArray.Select(c => c).ToArray());
        return String.Concat(messageArray);
    }

    private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
    {
        Console.WriteLine($"{reversedFirstName} {reversedLastName} {reversedCity}"); // bättre :) 
        // Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity)); 
    }
    
    //overload!!
    private static void DisplayResult(string message)
    {
        Console.Write($"Results: {message}");
    }
}
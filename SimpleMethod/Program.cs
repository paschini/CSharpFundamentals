// Created by following this video:
// [x] https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/defining-and-calling-methods

// not required anymore...
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace SimpleMethod;

class Program
{
    static void Main(string[] args)
    {
        HelloWorld();
        Console.ReadLine();
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }
}
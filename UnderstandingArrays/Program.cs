// Created by following this video:
// [x] https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/understanding-arrays

// not required anymore...
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace UnderstandingArrays;

class Program
{
    static void Main(string[] args)
    {
        // int number1 = 4;
        // int number2 = 8;
        // int number3 = 15;
        // int number4 = 16;
        // int number5 = 23;
        //
        // if (number1 == 4)
        // {
        //     
        // } else if (number2 == 8)
        // {
        //     
        // }
        
       // int[] numbers = new int[5];
       //
       // numbers[0] = 4;
       // numbers[1] = 8;
       // numbers[2] = 15;
       // numbers[3] = 16;
       // numbers[4] = 23;
       // // numbers[6] = 42;
       //
       // Console.WriteLine(numbers[1]);
       // Console.WriteLine(numbers.Length);
       
       // int[] numbers = new int[]  { 4, 8, 15, 16, 23, 42 };
       //
       // string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
       //
       // for (int i = 0; i < names.Length; i++)
       // {
       //     Console.WriteLine(names[i]);
       // }

       string zig = "You can get what you want out of life " + "if you help enough people get what they want.";
       
       char[] charArray = zig.ToCharArray();
       Array.Reverse(charArray);

       foreach (char zigChar in charArray)
       {
           Console.Write(zigChar);
       }
       
       Console.ReadLine();
    }
}
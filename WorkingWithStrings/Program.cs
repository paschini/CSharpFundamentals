using System.Text;

namespace WorkingWithStrings;

class Program
{
    static void Main(string[] args)
    {
        // escaping characters
        string myString1 = "My \"so called\" string"; // escaping quotes
        string myString2 = "What if I need a \nnew line?"; // escaping new line
        string myString3 = "What if I need a \\ character? like in C:\\"; // escaping backslash
        string myString4 = @"Can also do this one C:\"; // escaping backslash with a @ annotation
        
        // string formatting options:
        string myString5 = String.Format("My string {0} {1} {2}", "with", "multiple", "arguments"); // can reuse arguments too {0} {0} {1} {2}
        string with = "with", multiple = "multiple", arguments = "arguments";
        string myString6 = $"My string {with} {multiple} {arguments}";
        
        // numbers formatting
        string myString7 = String.Format("{0:c}", 123.45); // location based currency formating
        string myString8 = String.Format("{0:n}", 123456789.123456789);
        string myString9 = String.Format("{0:n2}", 123456789.123456789);
        string myString10 = String.Format("{0:P}", .123);
        
        //phone numbers
        string myString11 = String.Format("{0:(###) ###-####}", 0767719519);
        string myString12 = String.Format("{0:(###) ###-####}", 07677195194545); // too many extra digits
        
        // changing the string
        string myString13 = "  I should have changed that fucking lock\nI would have made you leave your key  ";
        string mySubstring = myString13.Substring(6); // from 6 to the end
        string mySubstring2 = myString13.Substring(6, 42); // from 6 to 42
        string myString14 = myString13.Replace("fucking", "f+cking");
        string mySubstring15 = myString13.ToUpper();
        string mySubstring16 = myString13.Remove(30); // remove from index 30 to the end
        string mySubstring17 = myString13.Trim(); // remove leading and trailing whitespace

        // string numbersRoll = "";
        // for (int i = 0; i < 100; i++)
        // {
        //     numbersRoll += "--" + i + " ";
        //     Console.WriteLine(numbersRoll);
        // }
        
        StringBuilder myStringBuilder = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            // should be more efficient to append to aan object rather than a string
            myStringBuilder.Append("--" + i + " ");
            Console.WriteLine(myStringBuilder);
        }
        
        
        Console.WriteLine(mySubstring17);
        Console.ReadLine();
    }
}
namespace UnderstandingScope;

class Program
{
    // private field
    private static string k = ""; // available for all members of the class, but not outside of the class.
    // everything is private by default.
    
    static void Main(string[] args)
    {
        string j = "";
        for (int i = 0; i < 10; i++)
        {
            j = i.ToString(); // j exists here, it's still in scope
            k = i.ToString();
            Console.WriteLine(i);

            if (i == 9)
            {
                string l = i.ToString();
            }
            // Console.WriteLine(l); // l does not exist here, it's out of scope'
        }
        
        // i does not exist outside of the for loop, bnut j does.
        // and j is still in scope here.
        Console.WriteLine($"Outside the scope for i, but not for {j}");
        Console.WriteLine($"k exists here: {k}");
    }
    
    static void HelperMethod()
    {
       Console.WriteLine($"The value of k from the HelperMethod: {k}"); 
    }
}

class Car
{
    //Just like Java and Swift, there is a garbage collector that removes an object with no reference.
    // Ending the scope (as in the end of a function), the reference will be garbage collected and removed.
    // There is a free constructor.
   
    
    public string Make { get; set; } // this syntax is called auto-property
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    
    // Constructor method
    public Car() // <--- not needed if would be the same as free constructor
    {
        this.Make = "Tesla"; // this is optional here
        Model = "Model S"; // so this line is the same as above
        Year = 2021;
        Color = "White";
    }
    
    // Overloaded constructor method
    public Car(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    private void HiddenStuff()
    {
        Console.WriteLine("This is a private method, users of the class can't see it");
    }

    public void DoStuff()
    {
        Console.WriteLine("This is a public method, and can be called from an instance of the class");
    }

    public static void MyMethod()
    {
        // static declared methods can be used without instantiating the class and can be used anywhere if public and member of a public class.
        // they should always be stateless.  It's good practice to not mix static and instanced methods.
        Console.WriteLine("This is a static method");
    }
    
    // There is also protected and internal. It's more of a way to control access to members.
    // Relevant if controlling assemblies.
}
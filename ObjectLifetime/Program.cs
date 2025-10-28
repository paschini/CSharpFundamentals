namespace ObjectLifetime;

class Program
{
    static void Main(string[] args)
    {
       Car myCar = new Car(); // <--- this is a Constructor method
       
       myCar.Make = "Ford";
       myCar.Model = "Mustang";
       myCar.Year = 1964;
       myCar.Color = "Silver";

       Car myOtherCar = new Car();
       myOtherCar = myCar; // both point to the same reference, meaning altering one will alter the other

       myOtherCar.Model = "Fusion";
       Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} made in {myOtherCar.Year} colored {myOtherCar.Color}");
       Console.WriteLine($"{myCar.Make} {myCar.Model} made in {myCar.Year} colored {myCar.Color}.");

       myOtherCar = null; // <--- removes reference to the object
       // Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} made in {myOtherCar.Year} colored {myOtherCar.Color}"); // this line now causes an exception
       myCar = null; // now the object is garbage collected
       
       Car myFavoriteCar = new Car();
       Console.WriteLine($"My favorite car is {myFavoriteCar.Make} {myFavoriteCar.Model}.");
       
       Car myCurrentTesla = new Car("Tesla", "Model Y", 2021, "White");
       Console.WriteLine($"My current car is {myCurrentTesla.Make} {myCurrentTesla.Model}.");
       
       Car.MyMethod(); // <--- same as Array.Reverse :)
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

    public static void MyMethod()
    {
        // static declared methods can be used without instantiating the class and can be used anywhere if public and member of a public class.
        // they should always be stateless.  It's good practice to not mix static and instanced methods.
        Console.WriteLine("This is a static method");
    }
}
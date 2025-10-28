namespace UnderstandingClasses;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        
        myCar.Make = "Ford";
        myCar.Model = "Mustang";
        myCar.Year = 1964;
        myCar.Color = "Red";
        
        decimal value = DetermineMarketValue(myCar);
        
        Console.WriteLine($"{myCar.Make} {myCar.Model} made in {myCar.Year} colored {myCar.Color}. Value: {value:C}");
    }
    
    private static decimal DetermineMarketValue(Car car)
    {
        decimal carValue = 100M; // M for monetary?
        
        // could use an api and find the value of the car
        return carValue;
    }
}

class Car
{
    public string Make { get; set; } // this syntax is called auto-property
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }
}


namespace WorkingWithLINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>()
        {
            new Car() { VIN = "A1", Make = "Ford", Model = "Mustang", Year = 1964, Color = "Orange" },
            new Car() { VIN = "A2", Make = "Nissan", Model = "Aria", Year = 1990, Color = "Copper" },
            new Car() { VIN = "A3", Make = "Tesla", Model = "Model X", Year = 2022, Color = "Blue" },
            new Car() { VIN = "A4", Make = "Opel", Model = "Corsa", Year = 2004, Color = "Black" },
            new Car() { VIN = "A5", Make = "Lamborghini", Model = "Murciélago", Year = 1995, Color = "Graphite" },
            new Car() { VIN = "A5", Make = "Ferrari", Model = "SF90 Spider", Year = 2022, Color = "Silver" },
        };
        
        // LINQ query
        var myCars2 = from car in myCars
                       where car.Year > 2000
                       && car.Year <= 2020
                       select car;
        // can be merged into a pattern like so: car.Year is >= 2000 and <= 2020
        
        
        // LINQ method
        var ferraris = myCars.Where(car => car is { Make: "Ferrari" or "Lamborghini", Year: < 2000 });
        // var means let's make the compiler decide what type of variable to use

        foreach (var car in ferraris)
        {
            Console.WriteLine($"{car.Make} {car.Model} {car.Color} \n");
        }
        
        // var orderedCars = myCars.OrderBy(car => car.Year);
        // orderedCars.foreach (var car in orderedCars)
        // {
        //     Console.WriteLine($"{car.Make} {car.Model} {car.Color}");
        // }
        
        // LINQ method same as above
        myCars.OrderBy(car => car.Year).ToList().ForEach(car => Console.WriteLine($"{car.Make} {car.Model} {car.Color}"));
        
        Console.WriteLine($"\nI only have Ferraris: {myCars.TrueForAll(car => car.Make == "Ferrari")}");
    }
}

class Car
{
    public string VIN { get; set; }
    public string Make { get; set; } // this syntax is called auto-property
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}
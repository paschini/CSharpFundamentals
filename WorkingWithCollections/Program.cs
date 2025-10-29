using System.Collections;

namespace WorkingWithCollections;

class Program
{
    static void Main(string[] args)
    {
        // Collections are like Arrays, but they are dynamic and can contain pretty much anything, including objects.
        // You can have an Array of Objects, but collections are more flexible.
        
        Car car1 = new Car();
        car1.Make = "Oldsmobile";
        car1.Model = "Cutlass Supreme";
        car1.Year = 1969;
        car1.Color = "Silver";
        car1.VIN = "BAD 1234";
        
        Car car2 = new Car();
        car2.Make = "Ford";
        car2.Model = "Mustang";
        car2.Year = 1964;
        car2.Color = "Silver";
        car2.VIN = "CAD 1234";
        
        Book book1 = new Book();
        book1.Author = "Lewis Carrol";
        book1.Title = "Alice in Wonderland";
        book1.Year = 1865;
        book1.Publisher = "Macmillan";
        book1.ISBN = "978-0-19-520073-1";
        
        // ArrayLists are dynamically sized, cool features like sorting, removing items, etc
        // old school: cant limit the type of data...
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(car1);
        myArrayList.Add(car2);
        myArrayList.Add(book1); // perfectly legal
        myArrayList.Remove(book1); // fixes the crash but really... not a fix right?

        foreach (Car car in myArrayList) // The book crashes this loop
        {
            Console.WriteLine(car.Make);
        }
        
        // Enter Generics (List<T>) the type of T is specified, so cant mix objects
        List<Car> myList = new List<Car>();
        myList.Add(car1);
        myList.Add(car2);
        // myList.Add(book1); // doesnt go see? Safer

        foreach (Car car in myList)
        {
            Console.WriteLine($"{car.Make} {car.Model}");
        }
        
        // Dictionary key/value pair Dictionary<TKey, TValue>
        // good keys are unique
        
        Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
        myDictionary.Add(car1.VIN, car1);
        myDictionary.Add(car2.VIN, car2);
        
        Console.WriteLine(myDictionary["CAD 1234"].Make);

        // create, iinitialize, and populate in "1 go"! - Object initializer syntax
        // no need to use the constructor
        string[] names = { "Bob", "Steve", "Brian", "Camila" };
        Car car3 = new Car() { Make = "BMW", Model = "M3", Year = 2022, Color = "Red" };
        
        // Collection initializer syntax
        List<Car> myList2 = new List<Car>()
        {
            new Car { Make = "BMW", Model = "M3", Year = 2022, Color = "Red" },
            // new Car { car1 } // <--- this doenst go though
        };
    }
    
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
    }
}

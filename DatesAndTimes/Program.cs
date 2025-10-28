namespace DatesAndTimes;

class Program
{
    static void Main(string[] args)
    {
        DateTime myValue = DateTime.Now;
        
        Console.WriteLine(myValue.ToString("yyyy-MM-dd HH:mm:ss")); // the format is called "String culture", as it relates to the locale of the computer
        Console.WriteLine(myValue.ToShortDateString());
        Console.WriteLine(myValue.ToShortTimeString());
        Console.WriteLine(myValue.ToLongDateString());
        Console.WriteLine(myValue.ToLongTimeString());
        
        // DateTime Map
        Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // chained commands are fine
        Console.WriteLine(myValue.AddDays(3).AddHours(12).ToLongDateString());
        Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); // no subtraction of dates, but go ahead and use negative values :D
        
        DateTime myBirthDay = new DateTime(1979, 6, 25);
        Console.WriteLine(myBirthDay.ToShortDateString());
        Console.WriteLine(myBirthDay.ToLongDateString());
        
        DateTime myBirthDay2 = DateTime.Parse("1979-06-25");
        TimeSpan myAge = DateTime.Now.Subtract(myBirthDay2);
        Console.WriteLine(myBirthDay2.ToLongDateString());
        Console.WriteLine(myAge.Days);
        Console.WriteLine(myAge.Microseconds); // not the microseconds in the total TimeSpan...
        
        long totalMicroseconds = myAge.Ticks / 10; // 1 tick = 100 nanoseconds = 0.1 microsecond
        Console.WriteLine(totalMicroseconds); // now thats the expected result
    }
}
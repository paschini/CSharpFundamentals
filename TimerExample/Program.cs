using Tmr = System.Timers;

namespace TimerExample;

class Program
{
    static void Main(string[] args)
    {
        Tmr.Timer myTimer = new Tmr.Timer(1000);

        myTimer.Elapsed += MyTimer_Elapsed; // event handler binding
        myTimer.Elapsed += MyTimer_Elapsed2; // event handler extra binding binding
        myTimer.Start();
        
        Console.WriteLine("Press enter to remove one event: ");
        Console.ReadLine();
        
        myTimer.Elapsed -= MyTimer_Elapsed; // FILO?

        Console.ReadLine();
        
        // skipped the part with WPF cuz MaacOS
    }
    
    private static void MyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        // throw new NotImplementedException();
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss}");
    }
    
    private static void MyTimer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
    {
        // throw new NotImplementedException();
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss}");
    }
}
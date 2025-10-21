namespace Magic8Ball;

public static class Utilities
{
    // class with only static methods supposed to be used as one-off runs, so static works here.
    public static async Task ShowConsoleAnimation()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.Write("| -");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("/ \\");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("- |");
            await Task.Delay(50);
            Console.Write("\b\b\b");
            Console.Write("\\ /");
            await Task.Delay(50);
            Console.Write("\b\b\b");
        }

        Console.WriteLine();
    }
}
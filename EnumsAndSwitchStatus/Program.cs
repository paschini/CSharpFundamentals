using System.ComponentModel;

namespace EnumsAndSwitchStatus;

class Program
{
    static void Main(string[] args)
    {
        List<Todo> todos = new List<Todo>()
        {
            new Todo { Description = "Buy milk", EstimatedHours = 1, status = Status.NotStarted },
            new Todo { Description = "Buy eggs", EstimatedHours = 1, status = Status.InProgress },
            new Todo { Description = "Buy bread", EstimatedHours = 1, status = Status.Completed },
            new Todo { Description = "Finish watching video course", EstimatedHours = 4, status = Status.InProgress },
            new Todo { Description = " Wait for bedömning klart", EstimatedHours = 3, status = Status.OnHold }
        };
        
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        
        PrintAssessment(todos);
    }

    static void PrintAssessment(List<Todo> todos)
    {
        foreach (var todo in todos)
        {
            switch (todo.status)
            {
                case Status.Completed:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case Status.InProgress:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case Status.OnHold:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case Status.NotStarted:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case Status.Deleted:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
            
            Console.WriteLine($"Task: {todo.Description} Status: {todo.status}");
        }
    }
}

class Todo
{
    public string Description { get; set; }
    public int EstimatedHours { get; set; }
    public Status status { get; set; }
}

enum Status
{
    NotStarted,
    InProgress,
    OnHold,
    Completed,
    Deleted
}
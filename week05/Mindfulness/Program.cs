//So for the extra points, I created an gratitude class where the user can say things that they are grateful for

using System.IO;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---");
        Console.WriteLine(_description);

        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(2);

        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(2);

        LogActivity(); // ⭐ NEW
    }

    protected void LogActivity()
    {
        File.AppendAllText("log.txt", $"{_name} completed on {DateTime.Now}\n");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
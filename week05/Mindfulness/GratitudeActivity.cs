class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude", "Focus on things you are grateful for.")
    {
    }

    public void Run()
    {
        StartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> entries = new List<string>();

        Console.WriteLine("Start listing things you're grateful for:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            entries.Add(Console.ReadLine());
        }

        Console.WriteLine($"You wrote {entries.Count} gratitude items!");
        EndMessage();
    }
}
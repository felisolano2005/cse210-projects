class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private List<string> _usedPrompts = new List<string>();

    public ListingActivity()
        : base("Listing", "List positive things in your life.")
    {
    }

    public void Run()
    {
        StartMessage();

        string prompt = GetUniquePrompt();
        Console.WriteLine(prompt);

        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndMessage();
    }

    private string GetUniquePrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
            _usedPrompts.Clear();

        Random rand = new Random();
        string prompt;

        do
        {
            prompt = _prompts[rand.Next(_prompts.Count)];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }
}
class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame something hard.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made it special?"
    };

    private List<string> _usedPrompts = new List<string>();

    public ReflectionActivity()
        : base("Reflection", "Reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        string prompt = GetUniquePrompt();
        Console.WriteLine(prompt);
        ShowSpinner(3);

        Random rand = new Random();
        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(4);
            time += 4;
        }

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
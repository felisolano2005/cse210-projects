class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "Relax by breathing slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            AnimateBreathing("Breathe in...");
            AnimateBreathing("Breathe out...");
            time += 6;
        }

        EndMessage();
    }

    private void AnimateBreathing(string text)
    {
        Console.WriteLine(text);

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("*".PadLeft(i));
            Thread.Sleep(400);
            Console.Write("\r");
        }
        Console.WriteLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";

        if (number >= 90)
        letter = "A";

        else if (number >= 80)
        letter = "B";

        else if (number >= 70)
        letter = "C";

        else if (number >= 60)
        letter = "D";

        else
        letter = "F";

        Console.WriteLine($"You have earned the grade {letter}");

        if (number >= 70)
        Console.WriteLine("Congratulations, you passed the course");
        else
        Console.WriteLine("Enter a valid number!");
    }
}
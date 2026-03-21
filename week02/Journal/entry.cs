using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _responseText;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _promptText = prompt;
        _responseText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_responseText}\n");
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_responseText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
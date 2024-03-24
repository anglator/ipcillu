using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetPrettyDate(DateTime.Now.AddMinutes(-25)));
    }

    public static string GetPrettyDate(DateTime date)
    {
        // Example of a "pretty" format: "Friday, March 22, 2024, at 5:48 PM"
        return date.ToString("dddd, MMMM dd, yyyy, 'at' h:mm tt");
    }
}

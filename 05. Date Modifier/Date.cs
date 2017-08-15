using System;
using System.Globalization;

public static class Date
{
    public static void Main()
    {
        var firstDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(Console.ReadLine(), "yyyy MM dd", CultureInfo.InvariantCulture);

        Console.WriteLine(Math.Abs(DateModifier.GetDifference(firstDate, secondDate)));

    }
}


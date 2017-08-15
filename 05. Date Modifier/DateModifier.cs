using System;

public class DateModifier
{

    public static int GetDifference(DateTime firstDate, DateTime secondDate)
    {
        var diff = firstDate.Subtract(secondDate);
        var asdd = diff.Days;
        return asdd;
    }

}

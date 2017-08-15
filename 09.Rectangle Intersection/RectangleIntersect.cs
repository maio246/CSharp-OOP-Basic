using System;
using System.Collections.Generic;
using System.Linq;

public static class RectangleIntersect
{
    public static void Main()
    {
        var rectangleCount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < rectangleCount[0]; i++)
        {
            var rectArgs = Console.ReadLine().Split();

            var currRect = new Rectangle(
                rectArgs[0],
                double.Parse(rectArgs[1]),
                double.Parse(rectArgs[2]),
                double.Parse(rectArgs[3]),
                double.Parse(rectArgs[4])
                );
            rectangles[rectArgs[0]] = currRect;
        }

        for (int i = 0; i < rectangleCount[1]; i++)
        {
            var checkIds = Console.ReadLine().Split();
            var result = rectangles[checkIds[0]].IntersectsWith(rectangles[checkIds[1]]);

            Console.WriteLine(result.ToString().ToLower());
        } 
    }
}

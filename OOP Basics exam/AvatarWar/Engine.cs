using System;
using System.Linq;

public class Engine
{

    public void StartUp()
    {
        var builder = new NationsBuilder();
        string inputLine;

        while ((inputLine = Console.ReadLine()) != "Quit")
        {
            var commandTokens = inputLine.Split().ToList();

            var command = commandTokens[0];
            var nationType = commandTokens[1];

            switch (command)
            {
                case "Bender":
                    builder.AssignBender(commandTokens);
                    break;
                case "Monument":
                    builder.AssignMonument(commandTokens);
                    break;
                case "Status":
                    Console.WriteLine(builder.GetStatus(nationType));
                    break;
                case "War":
                    builder.IssueWar(nationType);
                    break;
            }
        }

        Console.WriteLine(builder.GetWarsRecord());
    }
}


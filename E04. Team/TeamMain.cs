using System;
using System.Collections.Generic;

public static class TeamMain
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        var team = new Team("teams");

        foreach (var person in persons)
        {
            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}


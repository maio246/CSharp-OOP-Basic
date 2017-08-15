    using System;

public static class OldestMember
{
    public static void Main()
    {

        int input = int.Parse(Console.ReadLine());
        var members = new Family();

        for (int i = 0; i < input; i++)
        {

            var personParams = Console.ReadLine().Split();

            var name = personParams[0];
            var age = int.Parse(personParams[1]);

            var member = new Person(name, age);

            members.AddMember(member);

        }
        var oldest = members.GetOldestMember();

        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Poll
    {
        public static void Main()
        {
            var inputPersons = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < inputPersons; i++)
            {
                var tokens = Console.ReadLine().Split();

                var currPerson = new Person()
                {
                    name = tokens[0],
                    age = int.Parse(tokens[1])
                };

                people.Add(currPerson);
            }
            var result = people.Where(x => x.age > 30).OrderBy(x => x.name);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }

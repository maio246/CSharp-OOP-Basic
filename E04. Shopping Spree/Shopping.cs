using System;
using System.Collections.Generic;
using System.Linq;

public class Shopping
{
    public static void Main()
    {
        var people = new Dictionary<string, Person>();
        var products = new Dictionary<string, Product>();

        try
        {
            InputBuyers(people);

            InputProducts(products);
            string purchase;

            while ((purchase = Console.ReadLine()) != "END")
            {
                var tokens = purchase
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (people.ContainsKey(tokens[0]) &&
                    products.ContainsKey(tokens[1]))
                {
                    var person = people[tokens[0]];
                    var product = products[tokens[1]];

                    if (person.Money >= product.Cost)
                    {
                        person.AddToCart(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }

                }
            }

            people
                .Where(p => p.Value.Bag.Count != 0)
                .ToList()
                .ForEach(p => 
                Console.WriteLine(p.Value.Name + " - " + string.Join(", ", p.Value.Bag)));

            people
                .Where(p => p.Value.Bag.Count == 0)
                .ToList().ForEach(p => 
                Console.WriteLine($"{p.Value.Name.ToString()} - Nothing bought"));
                
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void InputProducts(Dictionary<string, Product> products)
    {
        var currProduct = Console.ReadLine()
            .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        for (int j = 0; j < currProduct.Length; j++)
        {
            var tokens = currProduct[j].Split('=');
            var name = tokens[0];
            var cost = decimal.Parse(tokens[1]);

            var product = new Product(name, cost);

            products[name] = product;

        }
    }

    private static void InputBuyers(Dictionary<string, Person> people)
    {
        var persons = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        for (int j = 0; j < persons.Length; j++)
        {
            var tokens = persons[j].Split('=');
            var name = tokens[0];
            var money = decimal.Parse(tokens[1]);

            var person = new Person(name, money);

            people[name] = person;
        }
    }
}


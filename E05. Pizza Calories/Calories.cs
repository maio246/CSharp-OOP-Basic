using System;

public static class Calories
{
    public static void Main()
    {
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split();

            try
            {
               
                switch (tokens[0])
                {
                    case "Dough":
                        var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                        Console.WriteLine($"{dough.GetCalories():f2}");
                        break;
                    case "Topping":
                        var top = new Topping(tokens[1], double.Parse(tokens[2]));
                        Console.WriteLine($"{top.GetCalories():f2}");
                        break;
                    case "Pizza":
                        MakePizza(tokens);
                        break;
                        
                }
            }
            catch
                (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private static void MakePizza(string[] tokens)
    {
        var doughInf = Console.ReadLine().Split();
        var dough = new Dough(doughInf[1], doughInf[2], double.Parse(doughInf[3]));
        var pizza = new Pizza(tokens[1], dough, int.Parse(tokens[2]));

        var numbToppings = int.Parse(tokens[2]);

        for (int i = 0; i < numbToppings; i++)
        {
            var topInf = Console.ReadLine().Split();

            var top = new Topping(topInf[1], double.Parse(topInf[2]));
        }

        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
    }
}


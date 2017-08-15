using System;
using System.CodeDom;

public static class WildFarmProg
{
    public static void Main()
    {
        string inputLine;

        while ((inputLine = Console.ReadLine()) != "End")
        {
            var animalTokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Animal currAnimal = null;

            var name = animalTokens[1];
            var type = animalTokens[0];
            var weight = double.Parse(animalTokens[2]);
            var home = animalTokens[3];

            switch (animalTokens[0])
            {
                case "Cat":
                    currAnimal = new Cat(name, type, weight, home, animalTokens[4]);
                    break;
                case "Tiger":
                    currAnimal = new Tiger(name, type, weight, home);
                    break;
                case "Zebra":
                    currAnimal = new Zebra(name, type, weight, home);
                    break;
                case "Mouse":
                    currAnimal = new Mouse(name, type, weight, home);
                    break;
            }


            var foodTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Food food = null;

            if (foodTokens[0] == "Vegetable")
            {
                food = new Vegetable(int.Parse(foodTokens[1]));
            }
            else
            {
                food = new Meat(int.Parse(foodTokens[1]));
            }
            currAnimal.MakeSound();
            currAnimal.EatFood(food);
            Console.WriteLine(currAnimal);
        }
    }
}


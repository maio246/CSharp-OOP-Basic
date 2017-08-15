using System;

public class Tiger : Feline
{
    public Tiger(string animalName, string animalType, double animalWeight, string livingReagion)
        : base(animalName, animalType, animalWeight, livingReagion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }

    public override void EatFood(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{this.AnimalType}s are not eating that type of food!");
        }
    }
}

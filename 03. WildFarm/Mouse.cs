using System;

public class Mouse : Mammal
{
    public Mouse(string animalName, string animalType, double animalWeight, string livingReagion)
        : base(animalName, animalType, animalWeight, livingReagion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }

    public override void EatFood(Food food)
    {
        if (food.GetType().Name == "Vegetable")
        {
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"Mouses are not eating that type of food");
        }
    }
}

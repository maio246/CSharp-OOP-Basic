using System;

public class Zebra : Mammal
{
    public Zebra(string animalName, string animalType, double animalWeight, string livingReagion)
    : base(animalName, animalType, animalWeight, livingReagion)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override void EatFood(Food food)
    {
        if (food.GetType().Name == "Vegetable")
        {
            this.FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{this.AnimalType}s are not eating that type of food");
        }
    }

}


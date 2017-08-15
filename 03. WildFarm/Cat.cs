using System;

public class Cat : Feline
{
    private string breed;

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public Cat(string animalName, string animalType, double animalWieght, string livingRegion, string breed)
        : base(animalName, animalType, animalWieght, livingRegion)
    {
        this.Breed = breed;
    }
    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override void EatFood(Food food)
    {
        base.FoodEaten += food.Quantity;
    }
}


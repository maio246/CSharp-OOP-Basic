using System;

public class Animal
{
    public string name;
    public string favoriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.name = name;
        this.favoriteFood = favoriteFood;
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.name} and my fovourite food is {this.favoriteFood}";
    }
}


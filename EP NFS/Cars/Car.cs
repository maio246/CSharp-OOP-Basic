using System.Collections.Generic;

public abstract class Car
{
    public string brand;
    public string model;
    public int yearOfProdution;
    public int horsePower;
    public int suspension;
    public int durability;
    public int acceleration;
    public int moneyWon;

    public List<string> addOns;
    public int stars;

    public int performancePoints;

    protected Car(string brand, string model, int yearOfProdution, int horsePower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProdution = yearOfProdution;
        this.horsePower = horsePower;
        this.suspension = suspension;
        this.durability = durability;
        this.acceleration = acceleration;
    }
}


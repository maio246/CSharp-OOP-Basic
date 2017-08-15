using System.Collections.Generic;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProdution, int horsePower, int acceleration, int suspention, int durability)
        : base(brand, model, yearOfProdution, horsePower, acceleration, suspention, durability)
    {
        this.addOns = new List<string>();
        this.horsePower += (horsePower * 50) / 100;
        this.suspension = suspention - ((suspention * 25) / 100);
    }

    public void AddOn(string addon)
    {
        addOns.Add(addon);
    }

}


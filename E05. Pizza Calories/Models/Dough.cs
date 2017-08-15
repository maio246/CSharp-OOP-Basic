using System;

public class Dough
{
    private string flourType;
    private string bakingTech;
    private double weight;

    private const int MinWieght = 1;
    private const int MaxWeight = 200;

    public Dough(string flourType, string bakingTech, double weight)
    {
        this.flourType = flourType;
        this.bakingTech = bakingTech;
        this.weight = weight;
    }
    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
            {
                throw new ArgumentException("Invalid type of dough");
            }

            this.flourType = value;
        }
    }

    public string BakingTech
    {
        get { return this.bakingTech; }
        set
        {
            if (value.ToLower() != "crispy" &&
                value.ToLower() != "chewy" &&
                value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough");
            }
            this.bakingTech = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < MinWieght || value > MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    public double GetCalories()
    {
        return 2 * this.weight * this.GetBakingTech() * this.GetFlowerType();
    }

    private double GetFlowerType()
    {
        if (this.flourType == "white")
        {
            return 1.5;
        }
        return 1;
    }

    private double GetBakingTech()
    {
        if (this.bakingTech.ToLower() == "crispy")
        {
            return 0.9;
        }
        else if (this.bakingTech.ToLower() == "chewy")
        {
            return 1.1;
        }
        return 1;
    }
}


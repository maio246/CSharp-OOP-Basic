public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    protected Animal(string animalName, string animalType, double animalWeight)
    {
        this.AnimalName = animalName;
        this.AnimalType = animalType;
        this.AnimalWeight = animalWeight;
        this.FoodEaten = foodEaten;
    }

    public string AnimalName
    {
        get { return this.animalName; }
        set { this.animalName = value; }
    }
    public string AnimalType
    {
        get { return this.animalType; }
        set { this.animalType = value; }
    }
    public double AnimalWeight
    {
        get { return this.animalWeight; }
        set { this.animalWeight = value; }
    }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }

    public abstract void MakeSound();

    public abstract void EatFood(Food food);
}


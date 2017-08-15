public abstract class Mammal : Animal
{
    private string livingRegion;

    public string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    protected Mammal
        (string animalName, string animalType, double animalWeight, string livingReagion)
        : base(animalName, animalType, animalWeight)
    {
        this.LivingRegion = livingReagion;
    }
}


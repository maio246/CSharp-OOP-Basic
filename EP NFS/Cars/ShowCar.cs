public class ShowCar : Car
{    
    public ShowCar(string brand, string model, int yearOfProdution, int horsePower,int acceleration, int suspention, int durability) 
        : base(brand, model, yearOfProdution, horsePower, acceleration, suspention, durability)
    {
        this.stars = 0;
    }

    public void AddStars(int starsToAdd)
    {
        stars += starsToAdd;
    }
}


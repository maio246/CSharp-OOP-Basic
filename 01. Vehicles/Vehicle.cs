public class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }


    private double FuelQuantity { get; set; }

    private double FuelConsumption { get; set; }
}


public class Truck :Vehicle
{
    public const double AcConsumption = 1.6;

    public const double FuelLossFactor = 0.95;

    public Truck(double fuelQuantity, double fuelPerKm, double fuelCapacity)
        : base(fuelQuantity, fuelPerKm + AcConsumption, fuelCapacity)
    { }

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * FuelLossFactor);
    }
}
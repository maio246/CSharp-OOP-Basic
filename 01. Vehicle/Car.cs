public class Car : Vehicle
{
    public const double AcConsumption = 0.9;

    public Car(double fuelQuantity, double fuelPerKm, double fuelCapacity)
        : base(fuelQuantity, fuelPerKm + AcConsumption, fuelCapacity)
    {}
}
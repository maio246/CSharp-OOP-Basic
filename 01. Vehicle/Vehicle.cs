using System;

public abstract class Vehicle
{
    private double FuelPerKm { get; set; }

    private double FuelQuantity { get; set; }

    private double FuelCapacity { get; set; }

    public Vehicle(double fuelQuantity, double fuelPerKm, double fuelCapacity)
    {
        this.FuelPerKm = fuelPerKm;
        this.FuelQuantity = fuelQuantity;
        this.FuelCapacity = fuelCapacity;
    }

    public string TryTravelDistance(double distance)
    {
        if (this.Drive(distance))
        {
            return $"{this.GetType().Name} travelled {distance} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }

    private bool Drive(double distance)
    {
        var fuelReq = distance * this.FuelPerKm;
        if (fuelReq <= this.FuelQuantity)
        {
            this.FuelQuantity -= fuelReq;
            return true;
        }
        return false;
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }
        else if (this.FuelQuantity + fuel > this.FuelCapacity)
        {
            if (GetType() == (typeof(Bus)) || GetType() == typeof(Car))
            {
                Console.WriteLine("Cannot fit fuel in tank");
                return;
            }
        }
        this.FuelQuantity += fuel;
    }

    public void DrivingEmptyBus() => this.FuelPerKm -= 1.4;
    
    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelPerKilometer;
    private double distanceTraveled;
    private double totalDistanceToTravel;

    public Car(string model, int fuelAmount, double fuelPerKilometer)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelPerKilometer = fuelPerKilometer;
        TotalDistanceToTravel(fuelAmount, fuelPerKilometer);
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelPerKilometer
    {
        get { return this.fuelPerKilometer; }
        set { this.fuelPerKilometer = value; }
    }

    private void TotalDistanceToTravel(double fuelAmount, double fuelPerKilometer)
    {
        this.totalDistanceToTravel = fuelAmount / fuelPerKilometer;
    }

    public double DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public void Distance(int kilometers)
    {
        if (this.totalDistanceToTravel >= kilometers)
        {
            this.totalDistanceToTravel -= kilometers;
            this.FuelAmount = totalDistanceToTravel * this.fuelPerKilometer;
            this.DistanceTraveled += kilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

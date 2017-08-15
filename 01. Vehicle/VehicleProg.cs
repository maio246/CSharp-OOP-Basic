using System;

public static class VehicleProg
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

        var truckInfo = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

        var busInfo = Console.ReadLine().Split();
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]) + 1.4, double.Parse(busInfo[3]));

        var commands = int.Parse(Console.ReadLine());

        for (int i = 0; i < commands; i++)
        {
            var tokens = Console.ReadLine().Split();

            var vehicleType = tokens[1];
            if (vehicleType == "Car")
            {
                ExecuteAction(car, tokens[0], double.Parse(tokens[2]));
            }
            else if (vehicleType == "Bus")
            {
                    ExecuteAction(bus, tokens[0], double.Parse(tokens[2]));
            }
            else
            {
                ExecuteAction(truck, tokens[0], double.Parse(tokens[2]));
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
    {
        string result;

        switch (command)
        {
                
            case "Drive":
                result = vehicle.TryTravelDistance(parameter);
                Console.WriteLine(result); 
                break;
            case "DriveEmpty":
                vehicle.DrivingEmptyBus();
                result = vehicle.TryTravelDistance(parameter);
                Console.WriteLine(result);
                break;
            case "Refuel":
                vehicle.Refuel(parameter);
                break;
        }
    }
}
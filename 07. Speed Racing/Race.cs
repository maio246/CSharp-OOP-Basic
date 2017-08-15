using System;
using System.Collections.Generic;

public static class Race
{
    public static void Main()
    {
        var carsCount = int.Parse(Console.ReadLine());

        var cars = new Dictionary<string, Car>();

        for (int i = 0; i < carsCount; i++)
        {
            var currCar = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var model = currCar[0];
            var fuel = int.Parse(currCar[1]);
            var fuelPerKm = double.Parse(currCar[2]);

            var car = new Car(model, fuel, fuelPerKm);

            cars.Add(model, car);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var distanceParams = input.Split(' ');
            var model = cars[distanceParams[1]];
            var distance = int.Parse(distanceParams[2]);

            model.Distance(distance);
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine($"{car.Model:f2} {car.FuelAmount:f2} { car.DistanceTraveled}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public static class CarSales
{
    public static void Main()
    {
        var engines = new Dictionary<string, Engine>();

        var enginesToAdd = int.Parse(Console.ReadLine());

        for (int i = 0; i < enginesToAdd; i++)
        {
            var engArgs = Console.ReadLine().Split();

            var currEngine = new Engine(engArgs[0], engArgs[1]);

            if (engArgs.Length == 3)
            {
                currEngine.Displacement = engArgs[2];
            }
            if (engArgs.Length == 4)
            {
                currEngine.Efficiency = engArgs[3];
            }

            engines.Add(engArgs[0], currEngine);
        }

        var cars = new List<Car>();

        var carsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carsCount; i++)
        {
            var carArgs = Console.ReadLine().Split();

            var currCar = new Car(carArgs[0], carArgs[1]);

            if (carArgs.Length == 3)
            {
                currCar.Weigth = carArgs[2];
            }
            if (carArgs.Length == 4)
            {
                currCar.Color = carArgs[3];
            }

            cars.Add(currCar);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Model + ":");
            foreach (var engine in engines)
            {
                if (engines.Any(c => c.Equals(car.Engine)))
                {
                    var eng = engines[engine.Value.Model];
                    Console.WriteLine(car.Engine + ":");
                    Console.WriteLine("Power: {eng.Power}");
                    Console.WriteLine("Displacement: {eng.Displacement}");
                    Console.WriteLine($"Efficiency: {eng.Efficiency}");
                }
                Console.WriteLine($"Weight: {car.Weigth}");
                Console.WriteLine($"Color: {car.Color}");
            }
        }
    }
}


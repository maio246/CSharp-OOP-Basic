using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;

    private readonly Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {

        Car currCar = null;

        if (type == "Performance")
        {
            currCar = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }
        else
        {
            currCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }

        cars.Add(id, currCar);
    }

    public string Check(int id)
    {
        Car car = null;

        if (cars.ContainsKey(id))
        {
            car = cars[id];
        }
        else if (garage.parkedCars.ContainsKey(id))
        {
            car = garage.parkedCars[id];
        }

        var carBuilder = new StringBuilder();

        carBuilder.AppendLine($"{car.brand} {car.model} {car.yearOfProdution}");
        carBuilder.AppendLine($"{car.horsePower} HP, 100 m/h in {car.acceleration} s");
        carBuilder.AppendLine($"{car.suspension} Suspension force, {car.durability} Durability");
        if (car.GetType().Name == "PerformanceCar")
        {
            if (car.addOns.Count != 0)
            {
                carBuilder.AppendLine($"Add-ons: {string.Join(", ", car.addOns)}");
            }
            else
            {
                carBuilder.AppendLine("Add-ons: None");
            }
        }
        else
        {
            carBuilder.AppendLine($"{car.stars} *");
        }
        return carBuilder.ToString().Trim();

    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race currRace = null;

        switch (type)
        {
            case "Drag":
                currRace = new DragRace(length, route, prizePool);
                races.Add(id, currRace);
                break;
            case "Casual":
                currRace = new CasualRace(length, route, prizePool);
                races.Add(id, currRace);
                break;
            case "Drift":
                currRace = new DriftRace(length, route, prizePool);
                races.Add(id, currRace);
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!garage.parkedCars.ContainsKey(carId))
        {
            var carCandidate = cars[carId];
            races[raceId].AddRacer(carId, carCandidate);
        }
    }

    public string Start(int id)
    {
        var raceBuilder = new StringBuilder();

        var currentRace = races[id];
        var raceType = currentRace.GetType().Name;
        var winners = GetRaceWinners(currentRace, raceType);
        var prizePool = currentRace.prizePool;

        if (currentRace.participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        else
        {
            raceBuilder.AppendLine($"{currentRace.route} - {currentRace.length}");

            for (int i = 0; i < winners.Count; i++)
            {
                if (i == 0)
                {
                    var winner = winners[0];
                    raceBuilder.AppendLine(
                        $"{i + 1}. {winner.brand} {winner.model} {winner.performancePoints}PP - ${(prizePool * 50) / 100}");
                }
                else if (i == 1)
                {
                    var winner = winners[1];
                    raceBuilder.AppendLine(
                        $"{i + 1}. {winner.brand} {winner.model} {winner.performancePoints}PP - ${(prizePool * 30) / 100}");
                }
                else if (i == 2)
                {
                    var winner = winners[2];
                    raceBuilder.AppendLine(
                        $"{i + 1}. {winner.brand} {winner.model} {winner.performancePoints}PP - ${(prizePool * 20) / 100}");

                }
            }
            return raceBuilder.ToString().Trim();
        }
    }

    private List<Car> GetRaceWinners(Race currentRace, string raceType)
    {
        var winners = new List<Car>();
        var parts = currentRace.participants;

        switch (raceType)
        {
            case "DriftRace":
                foreach (var part in parts.Values)
                {
                    part.performancePoints = part.suspension + part.durability;
                }
                break;
            case "CasualRace":
                foreach (var part in parts.Values)
                {
                    part.performancePoints = (part.horsePower / part.acceleration) + (part.suspension + part.durability);
                }
                break;
            case "DragRace":
                foreach (var part in parts.Values)
                {
                    part.performancePoints = part.horsePower / part.acceleration;
                }
                break;
        }
        winners = parts
            .Values
            .OrderByDescending(p => p.performancePoints)
            .ThenBy(p => p)
            .ToList()
            .Take(3)
            .ToList();

        return winners;
    }

    public void Park(int id)
    {
        var carToPark = cars[id];

        if (!races.Values.Any(p => p.participants.ContainsKey(id)) && cars.ContainsKey(id))
        {
            garage.ParkCar(id, carToPark);
            cars.Remove(id);
        }
    }

    public void Unpark(int id)
    {
        var carToUnpark = garage.UnparcCar(id);
        cars.Add(carToUnpark.Key, carToUnpark.Value);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        garage.TuneCar(tuneIndex, addOn);
    }

}


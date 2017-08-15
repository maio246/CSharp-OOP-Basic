using System;

public class Engine
{
    public void StartUp()
    {
        string inputLine;
        CarManager manager = new CarManager();

        while ((inputLine = Console.ReadLine()) != "Cops Are Here")
        {

            var commandTokens = inputLine.Split();

            var command = commandTokens[0];
            var id = int.Parse(commandTokens[1]);
            switch (command)
            {
                case "register":
                    RegisterVehicle(commandTokens, manager);
                    break;
                case "check":
                    var result = manager.Check(id);
                    Console.WriteLine(result);
                    break;
                case "open":
                    var type = commandTokens[2];
                    var length = int.Parse(commandTokens[3]);
                    var route = commandTokens[4];
                    var prizePool = int.Parse(commandTokens[5]);

                    manager.Open(id, type, length, route, prizePool);
                    break;
                case "participate":
                    var raceId = int.Parse(commandTokens[2]);

                    manager.Participate(id, raceId);
                    break;
                case "start":
                    var winners = manager.Start(id);
                    Console.WriteLine(winners);
                    break;
                case "park":
                    manager.Park(id);
                    break;
                case "unpark":
                    manager.Unpark(id);
                    break;
                case "tune":
                    manager.Tune(id, commandTokens[2]);
                    break;
            }
        }
    }

    private static void RegisterVehicle(string[] carTokens, CarManager manager)
    {
        var id = int.Parse(carTokens[1]);
        var carType = carTokens[2];
        var brand = carTokens[3];
        var model = carTokens[4];
        var yearOfProdction = int.Parse(carTokens[5]);
        var horsePower = int.Parse(carTokens[6]);
        var acceleration = int.Parse(carTokens[7]);
        var suspension = int.Parse(carTokens[8]);
        var durability = int.Parse(carTokens[9]);

        manager.Register(id, carType, brand, model, yearOfProdction, horsePower, acceleration, suspension, durability);
    }
}


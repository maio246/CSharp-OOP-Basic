using System.Collections.Generic;

public class Garage
{
    public Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public void TuneCar(int tuneIndex, string addOn)
    {
        if (parkedCars.Count != 0)
        {
            foreach (var parkedCar in parkedCars.Values)
            {
                var carType = parkedCar.GetType().Name;

                if (carType == "PerformanceCar")
                {
                    parkedCar.horsePower += tuneIndex;
                    parkedCar.suspension += tuneIndex / 2;
                    parkedCar.addOns.Add(addOn);
                }
                else
                {
                    parkedCar.horsePower += tuneIndex;
                    parkedCar.suspension += tuneIndex / 2;
                    parkedCar.stars += tuneIndex;
                }
            }
        }
    }

    public void ParkCar(int id, Car car)
    {
        this.parkedCars.Add(id, car);
    }

    public KeyValuePair<int, Car> UnparcCar(int id)
    {
        var carToUnpark = parkedCars[id];
        this.parkedCars.Remove(id);
        return new KeyValuePair<int, Car>(id, carToUnpark);
    }
}


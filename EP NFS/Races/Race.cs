using System.Collections.Generic;

public abstract class Race
{
    public Dictionary<int, Car> participants;
    public int prizePool;
    public string route;
    public int length;

    protected Race(int length, string route, int prizePool)
    {
        this.route = route;
        this.length = length;
        this.prizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
        
    }

    public void AddRacer(int id, Car car)
    {
        participants.Add(id, car);
    }

}

using System.Collections.Generic;

public class Nation
{
    public List<Bender> benders;
    public List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public void Add(Bender bender)
    {
        benders.Add(bender);
    }

    public void Add(Monument monument)
    {
        monuments.Add(monument);
    }
}


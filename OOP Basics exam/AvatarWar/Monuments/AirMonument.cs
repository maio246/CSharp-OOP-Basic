public class AirMonument : Monument
{

    public int AirAffinity
    {
        get { return this.affinity; }
        set { affinity = value; }
    }

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public override string ToString()
    {
        return $"Air Monument: {monumentName}, Air Affinity: {affinity}";
    }
}


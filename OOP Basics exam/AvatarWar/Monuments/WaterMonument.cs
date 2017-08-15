public class WaterMonument : Monument
{
    public int WaterAffinity
    {
        get { return this.affinity; }
        set { affinity = value; }
    }

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public override string ToString()
    {
        return $"Water Monument: {monumentName}, Water Affinity: {affinity}";
    }
}


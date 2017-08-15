public class EarthMonument : Monument
{
    public int EarthAffinity
    {
        get { return this.affinity; }
        set { affinity = value; }
    }

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }
    public override string ToString()
    {
        return $"Fire Monument: {monumentName}, Fire Affinity: {affinity}";
    }

}


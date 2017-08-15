public class FireMonument : Monument
{
    public int FireAffinity
    {
        get { return this.affinity; }
        set { affinity = value; }
    }

    public FireMonument(string name, int fireAffinity) : base(name)
    {
        this.FireAffinity = fireAffinity;
    }
    public override string ToString()
    {
        return $"Fire Monument: {monumentName}, Fire Affinity: {affinity}";
    }

}


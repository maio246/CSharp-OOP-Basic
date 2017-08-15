public class FireBender : Bender
{
    private double heatAggression;

    public double HeatAggression
    {
        get { return heatAggression; }
        set { heatAggression = value; }
    }

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override string ToString()
    {
        return $"Fire Bender: {benderName}, Power: {power}, Heat Aggression: {heatAggression:f2}";
    }
}


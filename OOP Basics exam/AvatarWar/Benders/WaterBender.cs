public class WaterBender : Bender
{
    private double waterClarity;

    public double WaterClarity
    {
        get { return waterClarity; }
        set { waterClarity = value; }
    }

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override string ToString()
    {
        return $"Water Bender: {benderName}, Power: {power}, Water Clarity: {waterClarity:f2}";
    }
}


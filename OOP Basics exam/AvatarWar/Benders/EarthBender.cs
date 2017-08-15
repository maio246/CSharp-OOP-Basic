public class EarthBender : Bender
{
    private double groundSaturation;

    public double GroundSaturation
    {
        get { return groundSaturation; }
        set { groundSaturation = value; }
    }

    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override string ToString()
    {
        return $"Earth Bender: {benderName}, Power: {power}, Ground Saturation: {groundSaturation:f2}";
    }
}


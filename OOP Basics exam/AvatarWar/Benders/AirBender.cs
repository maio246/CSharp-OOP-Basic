public class AirBender : Bender
{
    private double aerialIntegrity;
    
    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        set { aerialIntegrity = value; }
    }

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air Bender: {benderName}, Power: {power}, Aerial Integrity: {aerialIntegrity:f2}";
    }
}


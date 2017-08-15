public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput += (energyOutput * 50) / 100;
        this.Type = "Pressure";
    }
}


using System;
using System.Text;

public abstract class Harvester : Factory
{
    private double oreOutput;
    private double energyRequirement;
    private string type;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.OreOutput = oreOutput;
        base.Id = id;
        this.EnergyRequirement = energyRequirement;
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
    public double OreOutput
    {
        get { return this.oreOutput; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }

    public override string Id
    {
        get { return this.Id; }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;

        }
    }

    public override string ToString()
    {
        var harvesterBuilder = new StringBuilder();

        harvesterBuilder.AppendLine($"{this.type} Harvester - {this.Id}");
        harvesterBuilder.AppendLine($"Ore Output: {this.oreOutput}");
        harvesterBuilder.AppendLine($"Energy Requirement: {this.energyRequirement}");

        return harvesterBuilder.ToString().Trim();
    }
}


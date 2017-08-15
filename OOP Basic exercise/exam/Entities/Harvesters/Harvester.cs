using System;
using System.Text;

public class Harvester : Worker
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    protected string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            }

            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var harvesterBuilder = new StringBuilder();
        var type = this.GetType().Name;
        var index = type.IndexOf("Harvester");
        type = type.Remove(index);

        harvesterBuilder.AppendLine($"{type} Harvester - {this.id}");
        harvesterBuilder.AppendLine($"Ore Output: {this.oreOutput}");
        harvesterBuilder.AppendLine($"Energy Requirement: {this.energyRequirement}");

        return harvesterBuilder.ToString().Trim();
    }
}
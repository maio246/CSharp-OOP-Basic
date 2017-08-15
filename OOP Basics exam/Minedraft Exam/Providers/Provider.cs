using System;
using System.Text;

public abstract class Provider : Factory
{
    public double energyOutput;
    public string type;

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public string Id
    {
        get { return this.Id; }
        set { this.Id = value; }
    }

    public override string ToString()
    {
        var providerBuilder = new StringBuilder();

        providerBuilder.AppendLine($"{this.type} Provider - {this.Id}");
        providerBuilder.AppendLine($"Energy Output: {this.energyOutput}");

        return providerBuilder.ToString().Trim();

    }
}



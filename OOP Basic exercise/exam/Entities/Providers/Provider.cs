using System;
using System.Text;

public class Provider : Worker
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    protected string Id
    {
        get => this.id;
        set => this.id = value;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;
        set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }

            this.energyOutput = value;
        } 
    }

    public override string ToString()
    {
        var providerBuilder = new StringBuilder();
        var type = this.GetType().Name;
        var index = type.IndexOf("Provider");
        type = type.Remove(index);
        providerBuilder.AppendLine($"{type} Provider - {this.id}");
        providerBuilder.AppendLine($"EnergyOutput: {this.energyOutput}");

        return providerBuilder.ToString().Trim();
    }
}
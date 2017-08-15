using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    public double totalEnergyStored;
    public double totalMinedOre;
    public string mode;

    public List<Harvester> harvesters;
    public List<Provider> providers;

    public DraftManager()
    {
        this.providers = new List<Provider>();
        this.harvesters = new List<Harvester>();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var type = arguments[1];
            var id = arguments[2];
            var oreOutput = double.Parse(arguments[3]);
            var energyRequirement = double.Parse(arguments[4]);
            int sonicFactor = 0;

            Harvester currHarvester = null;

            switch (type)
            {
                case "Hammer":
                    currHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                    break;
                case "Sonic":
                    sonicFactor = int.Parse(arguments[5]);
                    currHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                    break;
            }

            harvesters.Add(currHarvester);
            return $"Successfully registered {type} Harvester - {id}";

        }
        catch (Exception e)
        {
            return (e.Message);
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var type = arguments[1];
            var id = arguments[2];
            var energyOutput = double.Parse(arguments[3]);
            Provider currProvider = null;

            switch (type)
            {
                case "Solar":
                    currProvider = new SolarProvider(id, energyOutput);
                    break;
                case "Pressure":
                    currProvider = new PressureProvider(id, energyOutput);
                    break;
            }
            providers.Add(currProvider);

            return $"Successfully registered {type} Provider - {id}";
        }
        catch (Exception e)
        {
            return (e.Message);
        }
    }

   public string Day()
    {
        double summedEnergyOutput = providers.Sum(p => p.EnergyOutput);
        double summedOreOutput = 0.0;


        var energyToWork = harvesters.Sum(h => h.EnergyRequirement);

        var dayBuilder = new StringBuilder();

        if (energyToWork <= totalEnergyStored)
        {
            switch (mode)
            {
                case "Full":
                    summedOreOutput = harvesters.Sum(h => h.OreOutput);
                    totalEnergyStored -= energyToWork;
                    break;
                case "Energy":
                    break;
                case "Half":
                    summedOreOutput = (harvesters.Sum(h => h.OreOutput)) / 2;
                    summedEnergyOutput -= (summedEnergyOutput * 60) / 100;
                    break;
            }
        }

        dayBuilder.AppendLine("A day has passed.");
        dayBuilder.AppendLine($"Energy Provided: {summedEnergyOutput}");
        dayBuilder.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        this.totalEnergyStored += summedEnergyOutput; 
        this.totalMinedOre += summedOreOutput;

        return dayBuilder.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[1];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[1];

        if (harvesters.Any(h => h.Id == id))
        {
            Harvester harvester = harvesters.Find(h => h.Id == id);
            return harvester.ToString();
        }
        else if (providers.Any(p => p.Id == id))
        {
            Provider provider = providers.Find(p => p.Id == id);
            return provider.ToString();
        }
        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        var shutdownBuilder = new StringBuilder();
        shutdownBuilder.AppendLine("System Shutdown");
        shutdownBuilder.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        shutdownBuilder.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return shutdownBuilder.ToString().Trim();
    }

}


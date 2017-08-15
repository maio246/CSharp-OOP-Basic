using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private double totalMinedOre;
    private double totalEnergyStored;
    private string mode;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
        this.totalMinedOre = 0;
        this.totalEnergyStored = 0;
        this.mode = "Full";
    }
    public string RegisterHarvester(List<string> arguments)
    {
        var msg = string.Empty;

        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var harvester = harvesterFactory.Get(arguments);
            harvesters[id] = harvester;
            msg = $"Successfully registered {type} Harvester {id}";
        }
        catch (Exception e)
        {
            msg = e.Message;
        }

        return msg;
    }

    public string RegisterProvider(List<string> arguments)
    {
        string msg = string.Empty;

        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var provider = providerFactory.Get(arguments);
            providers[id] = provider;
            msg = $"Successfully registered {type} Provider - {id}";
        }
        catch (Exception e)
        {
            msg = e.Message;
        }
        return msg;
    }

    public string Day()
    {
        double energyStoredforTheDay = providers.Values.Sum(p => p.EnergyOutput);
        double energyNeededForTheDay = harvesters.Values.Sum(h => h.EnergyRequirement);
        double oreMined = 0;

        totalEnergyStored += energyStoredforTheDay;

        if (totalEnergyStored >= energyNeededForTheDay)
        {
            if (mode == "Full")
            {
                this.totalEnergyStored -= energyStoredforTheDay;
                oreMined = harvesters.Values.Sum(h => h.OreOutput);

            }
            if (mode == "Half")
            {
                totalEnergyStored -= (energyNeededForTheDay * 60) / 100;
                oreMined += harvesters.Values.Sum(h => (h.OreOutput * 50) / 100);
            }
            totalMinedOre += oreMined;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {energyStoredforTheDay}");
        sb.AppendLine($"Plubus Ore Mined: {oreMined}");
        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[1];
        this.mode = arguments[1];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[1];
        var sb = new StringBuilder();
        if (providers.ContainsKey(id))
        {
            sb.Append(providers[id]);
        }
        else if (harvesters.ContainsKey(id))
        {
            sb.Append(harvesters[id]);
        }
        else
        {
            sb.AppendLine($"No element found with id – {id}");
        }
        return sb.ToString().Trim();
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");
        return sb.ToString().Trim();
    }
}
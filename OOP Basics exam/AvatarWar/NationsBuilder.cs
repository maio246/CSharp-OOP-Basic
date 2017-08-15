using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Nation fireNation;
    private Nation airNation;
    private Nation waterNation;
    private Nation earthNation;
    private int warCounter = 1;
    private  List<string> wars;


    public NationsBuilder()
    {
        this.fireNation = new Nation();
        this.airNation = new Nation();
        this.waterNation = new Nation(); 
        this.earthNation = new Nation(); 
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderType = benderArgs[1];
        var benderName = benderArgs[2];
        var power = int.Parse(benderArgs[3]);
        var integrity = double.Parse(benderArgs[4]);

        Bender currBender = null;

        switch (benderType)
        {
            case "Air":
                currBender = new AirBender(benderName, power, integrity);
                airNation.Add(currBender);
                break;
            case "Fire":
                currBender = new FireBender(benderName, power, integrity);
                fireNation.Add(currBender);
                break;
            case "Water":
                currBender = new WaterBender(benderName, power, integrity);
                waterNation.Add(currBender);
                break;
            case "Earth":
                currBender = new EarthBender(benderName, power, integrity);
                earthNation.Add(currBender);
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentType = monumentArgs[1];
        var monumentName = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        Monument currMonument = null;

        switch (monumentType)
        {
            case "Air":
                currMonument = new AirMonument(monumentName, affinity);
                    airNation.Add(currMonument);
                break;
            case "Fire":
                currMonument = new FireMonument(monumentName, affinity);
                fireNation.Add(currMonument);
                break;
            case "Water":
                currMonument = new WaterMonument(monumentName, affinity);
                waterNation.Add(currMonument);
                break;
            case "Earth":
                currMonument = new EarthMonument(monumentName, affinity);
                earthNation.Add(currMonument);
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        var nationBuilder = new StringBuilder();
        switch (nationsType)
        {
            case "Air":
                nationBuilder = GetNationString(airNation, nationsType);
                break;
            case "Fire":
                nationBuilder = GetNationString(fireNation, nationsType);
                break;
            case "Water":
                nationBuilder = GetNationString(waterNation, nationsType);
                break;
            case "Earth":
                nationBuilder = GetNationString(earthNation, nationsType);
                break;
        }
        return nationBuilder.ToString().Trim();
    }

    private StringBuilder GetNationString(Nation nation, string nationsType)
    {
        var nationBuilder = new StringBuilder();

        nationBuilder.AppendLine($"{nationsType} Nation").Append("Benders:");
        if (nation.benders.Count != 0)
        {
            nationBuilder.AppendLine();
            foreach (var nationBender in nation.benders)
            {
                nationBuilder.AppendLine($"###{nationBender}");
            }
        }
        else
        {
            nationBuilder.AppendLine(" None");
        }
        nationBuilder.Append("Monuments:");
        if (nation.monuments.Count != 0)
        {
            nationBuilder.AppendLine();
            foreach (var nationMonument in nation.monuments)
            {
                nationBuilder.AppendLine($"###{nationMonument}");
            }
        }
        else
        {
            nationBuilder.AppendLine(" None");
        }
        return nationBuilder;
    }

    public void IssueWar(string nationsType)
    {
        wars.Add(nationsType);

        var firePoints = GetPoints(fireNation);
        var airPoints = GetPoints(airNation);
        var earthPoints = GetPoints(earthNation);
        var waterPoints = GetPoints(waterNation);

        if (firePoints > airPoints &&
            firePoints > earthPoints &&
            firePoints > waterPoints)
        {
            airNation = new Nation();
            earthNation = new Nation();
            waterNation = new Nation();
        }
        else if (airPoints > firePoints &&
                 airPoints > earthPoints &&
                 airPoints > waterPoints)
        {
            fireNation = new Nation();
            earthNation = new Nation();
            waterNation = new Nation();

        }
        else if (waterPoints > airPoints &&
                 waterPoints > earthPoints &&
                 waterPoints > firePoints)
        {
            fireNation = new Nation();
            earthNation = new Nation();
            airNation = new Nation();

        }
        else if (earthPoints > firePoints &&
                 earthPoints > airPoints &&
                 earthPoints > waterPoints)
        {
            fireNation = new Nation();
            airNation = new Nation();
            waterNation = new Nation();

        }

    }

    private double GetPoints(Nation nation)
    {
        return (nation.benders.Sum(p => p.Power) / 100) *
            (nation.monuments.Sum(m => m.affinity));
    }

    public string GetWarsRecord()
    {
        var warBuilder = new StringBuilder();

        foreach (var war in wars)
        {
            warBuilder.AppendLine($"War {warCounter} issued by {war}");
            warCounter++;
        }

        return warBuilder.ToString().Trim();
    }

}


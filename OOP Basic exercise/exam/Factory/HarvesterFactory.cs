using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester Get(List<string> data)
    {
        var type = data[0];
        var id = data[1];
        var oreOutput = double.Parse(data[2]);
        var energyReq = double.Parse(data[3]);

        Harvester harvesterObj = null;
        if (type != "Sonic")
        {
            harvesterObj = new HammerHarvester(id, oreOutput, energyReq);
        }
        else
        {
            int sonicFactor = int.Parse(data[4]);
            harvesterObj = new SonicHarvester(id, oreOutput, energyReq, sonicFactor);
        }
        return harvesterObj;
    }
}
using System.Collections.Generic;

public class ProviderFactory
{
    public Provider Get(List<string> data)
    {
        var type = data[0];
        var id = data[1];
        var energyOutput = double.Parse(data[2]);

        Provider providerObj = null;

        if (type == "Solar")
        {
            providerObj = new SolarProvider(id, energyOutput);
        }
        else
        {
            providerObj = new PressureProvider(id, energyOutput);
        }
        return providerObj;
    }
}
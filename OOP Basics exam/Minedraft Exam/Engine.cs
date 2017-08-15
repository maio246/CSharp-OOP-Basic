using System;
using System.Linq;

public class Engine
{
    public void StartUp()
    {
        var draftManager = new DraftManager();

        string inputLine;

        while ((inputLine = Console.ReadLine()) != "Shutdown")
        {
            var inputTokens = inputLine
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = inputTokens[0];

            var result = string.Empty;
            switch (command)
            {
                case "RegisterHarvester":
                    result = draftManager.RegisterHarvester(inputTokens);
                    Console.WriteLine(result);
                    break;
                case "RegisterProvider":
                    result = draftManager.RegisterProvider(inputTokens);
                    Console.WriteLine(result);
                    break;
                case "Day":
                    result = draftManager.Day();
                    Console.WriteLine(result);
                    break;
                case "Check":
                    result = draftManager.Check(inputTokens);
                    Console.WriteLine(result);
                    break;
                case "Mode":
                    result = draftManager.Mode(inputTokens);
                    Console.WriteLine(result);
                    break;
            }
        }
        Console.WriteLine(draftManager.ShutDown());
    }
}

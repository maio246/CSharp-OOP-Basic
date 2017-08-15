using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private const string shutDown = "Shutdown";
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != shutDown)
        {
            List<string> arguments = input.Split().ToList();
            string command = arguments[0];

            switch (command)
            {
                case "RegisterHarvester":
                    arguments.Remove(command);
                    Console.WriteLine(draftManager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    arguments.Remove(command);
                    Console.WriteLine(draftManager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(arguments));
                    break;
            }
        }

        Console.WriteLine(draftManager.ShutDown());
    }
}
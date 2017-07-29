
using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = this.ReadInput();
            List<string> commandParameters = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        string command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "Bender":
                this.nationBuilder.AssignBender(commandParameters);
                break;
            case "Monument":
                this.nationBuilder.AssignMonument(commandParameters);
                break;
            case "Status":
                string status = this.nationBuilder.GetStatus(commandParameters[0]);
                this.OutputWriter(status);
                break;
            case "War":
                this.nationBuilder.IssueWar(commandParameters[0]);
                break;
            case "Quit":
                string record = this.nationBuilder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string status)
    {
        Console.WriteLine(status);
    }

    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split(' ').ToList();
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }
}

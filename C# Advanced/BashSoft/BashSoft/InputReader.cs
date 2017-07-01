using System;

namespace BashSoft
{
    public class InputReader
    {
        private const string endCommand = "quit";
        public static void StartReadingCommands()
        {
            while (true)
            {
                //Interpret command
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                string input = Console.ReadLine();
                input = input.Trim();
                CommandInterpreter.InterpredCommand(input);
                if (input == endCommand)
                {
                    break;
                }
            }
        }
    }
}
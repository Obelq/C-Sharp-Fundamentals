using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var text = new Stack<char>();
            var deleted = new Stack<char>();
            var lastCommandStack = new Stack<string[]>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                int command = int.Parse(input[0]);
                switch (command)
                {
                    case 1:
                        var chars = input[1].ToCharArray();
                        foreach (var c in chars)
                        {
                            text.Push(c);
                        }
                        lastCommandStack.Push(input);
                        break;
                    case 2:
                        int elementsToDelete = int.Parse(input[1]);
                        for (int j = 0; j < elementsToDelete; j++)
                        {
                            var deletedElement = text.Pop();
                            deleted.Push(deletedElement);
                        }
                        lastCommandStack.Push(input);
                        break;
                    case 3:
                        var textArr = text.ToArray();
                        int elementsToTake = int.Parse(input[1]);
                        Console.WriteLine(textArr[textArr.Length - elementsToTake]);
                        break;
                    case 4:
                        var lastCommand = lastCommandStack.Pop();
                        var commandUn = int.Parse(lastCommand[0]);
                        if (commandUn == 1)
                        {
                            for (int k = 0; k < lastCommand[1].Length; k++)
                            {
                                text.Pop();
                            }
                        }
                        else
                        {
                            int elementsToAdd = int.Parse(lastCommand[1]);
                            for (int j = 0; j < elementsToAdd; j++)
                            {
                                var deletedElement = deleted.Pop();
                                text.Push(deletedElement);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Error: Not valid command.");
                        break;
                }
            }

        }
    }
}

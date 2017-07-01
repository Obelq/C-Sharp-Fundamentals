using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace BashSoft
{
    public static class IOManager
    {
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = SessionData.currentPath + "\\" + name;
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException e)
            {
                OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessException);
            }
        }
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);
            while (subFolders.Count != 0)
            {

                var currentFolder = subFolders.Dequeue();
                int identation = currentFolder.Split('\\').Length - initialIdentation;
                if (depth - identation < 0)
                {
                    break;
                }
                OutputWriter.WriteMessageOnNewLine(currentFolder);
                try
                {
                    foreach (var file in Directory.GetFiles(currentFolder))
                    {
                        int indexOfLastSlash = file.LastIndexOf("\\");
                        string fileName = file.Substring(indexOfLastSlash);
                        Console.WriteLine(new string('-', indexOfLastSlash) + fileName);
                    }
                    foreach (var folder in Directory.GetDirectories(currentFolder))
                    {
                        subFolders.Enqueue(folder);
                    }
                }
                catch (UnauthorizedAccessException e)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessException);
                }
            }

        }
        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    string currentPath = SessionData.currentPath;
                    int indexOfLastSlash = currentPath.LastIndexOf("\\");
                    string newPath = currentPath.Substring(0, indexOfLastSlash);
                    SessionData.currentPath = newPath;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
                }
            }
            else
            {
                string currentPath = SessionData.currentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                throw new Exception("The folder/file you are trying to access at the current address, does not exist.");
            }

            SessionData.currentPath = absolutePath;
        }
    }
}

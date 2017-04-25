using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYJudgeSystem
{
    public class IOManager
    {
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = SessionData.currentPath + "\\" + name;
            Directory.CreateDirectory(path);
        }
        public static void TraverseDirectory(int depth)
        {
            Console.WriteLine();
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
                Console.WriteLine(currentFolder);
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
            
        }
        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                string currentPath = SessionData.currentPath;
                int indexOfLastSlash = currentPath.LastIndexOf("\\");
                string newPath = currentPath.Substring(0, indexOfLastSlash);
                SessionData.currentPath = newPath;
            }
            else
            {
                string currentPath = SessionData.currentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        private static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                throw new Exception("The folder/file you are trying to access at the current address, does not exist.");
            }

            SessionData.currentPath = absolutePath;
        }
    }
}

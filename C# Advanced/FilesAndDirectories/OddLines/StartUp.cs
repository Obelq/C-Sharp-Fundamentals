using DIYJudgeSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //OddLines();

            //LineNumbers();

            //WordCount();

            //MergingTwoFiles();

            //GetFolderSize();

            //Timer();

            ReadFromSpecifiedLine(2);
        }

        private static void ReadFromSpecifiedLine(int headStart)
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\02_OddLines";
            var input = File.ReadAllLines(currentDirectory + @"\01_OddLinesIn.txt");
            var result = new List<string>();

            for (int i = headStart; i < input.Length; i++)
            {
                result.Add(input[i]);
            }
            File.WriteAllLines(currentDirectory + @"\result1.txt", result);
            
        }

        private static void Timer()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises";
            var startTime = DateTime.Now;
            var file1 = File.ReadAllLines(currentDirectory + @"\File1.csv");
            var firstEndTime = DateTime.Now;
            var file2 = File.ReadAllLines(currentDirectory + @"\File2.txt.txt");
            var secondEndTime = DateTime.Now;
            if (secondEndTime - firstEndTime > firstEndTime - startTime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        private static void GetFolderSize()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\TestFolder";
            decimal folderSize = 0;
            var files = Directory.GetFiles(currentDirectory);
            foreach (var file in files)
            {
                decimal size1 = new FileInfo(file).Length / 1000000.0m;
                decimal size = File.ReadAllBytes(file).Length / 1000000.0m;
                folderSize += size1;
            }
            Console.WriteLine(folderSize);


        }

        private static void MergingTwoFiles()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\05_MergingFiles";
            var file1 = File.ReadAllLines(currentDirectory + @"\02_FileOne.txt");
            var file2 = File.ReadAllLines(currentDirectory + @"\02_FileTwo.txt");
            var minLength = Math.Min(file1.Length, file2.Length);
            var result = new List<string>();

            for (int i = 0; i < minLength; i++)
            {
                
                result.Add(file1[i]);
                result.Add(file2[i]);
            }
            for (int i = minLength; i < file1.Length; i++)
            {
                result.Add(file1[i]);
            }
            for (int i = minLength; i < file2.Length; i++)
            {
                result.Add(file2[i]);
            }

            File.WriteAllLines(currentDirectory + @"\result1.txt", result);
            Tester.CompareContent(currentDirectory + @"\result1.txt", currentDirectory + @"\02_Merged.txt");
        }

        private static void WordCount()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\04_WordCount";
            var words = File.ReadAllText(currentDirectory + @"\words1.txt").Split(' ').ToArray();

            var text = File.ReadAllText(currentDirectory + @"\text1.txt").Split(' ').Select(x => x.Trim()).ToArray();
            var result = new Dictionary<string,int>();

            for (int i = 0; i < words.Length; i++)
            {
                result[words[i]] = 0;
            }
            foreach (var word in text)
            {
                if (result.ContainsKey(word.ToLower()))
                {
                    result[word.ToLower()]++;
                }
            }
            var listRes = result.ToList();
            listRes.Sort((x, y) => x.Value.CompareTo(y.Value));

            //File.WriteAllLines(currentDirectory + @"\result1.txt", result);
            //Tester.CompareContent(currentDirectory + @"\result1.txt", currentDirectory + @"\01_LinesOut.txt");
        }

        private static void LineNumbers()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\03_LineNumbers";
            var input = File.ReadAllLines(currentDirectory + @"\01_LinesIn.txt");
            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Add($"{i+1}. {input[i]}");
            }
            File.WriteAllLines(currentDirectory + @"\result1.txt", result);
            Tester.CompareContent(currentDirectory + @"\result1.txt", currentDirectory + @"\01_LinesOut.txt");
        }

        private static void OddLines()
        {
            var currentDirectory = @"C:\Users\Georgi\Desktop\C# Advanced\03. CSharp-Advanced-Files-And-Directories-Exercises\02_OddLines";
            var input = File.ReadAllLines(currentDirectory + @"\01_OddLinesIn.txt");
            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(input[i]);
                }
            }
            File.WriteAllLines(currentDirectory + @"\result1.txt", result);
            Tester.CompareContent(currentDirectory + @"\result1.txt", currentDirectory + @"\01_OddLinesOut.txt");
        }
    }
}

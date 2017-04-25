using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYJudgeSystem
{
    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            Console.WriteLine("Reading files");
            string mismatchPath = GetMismatchPath(expectedOutputPath);

            var actualOutputLines = File.ReadAllLines(userOutputPath);
            var expectedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMismatch;
            string[] mismatches = GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMismatch);

            PrintOutput(mismatches, hasMismatch, mismatchPath);
            Console.WriteLine("Files read!");

        }

        private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    
                    Console.WriteLine(line);
                }
                File.WriteAllLines(mismatchPath, mismatches);
                return;
            }
            else
            {
                Console.WriteLine("Files are identical. There are no mismatches.");
            }

        }

        private static string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;
            string[] mismatches = new string[actualOutputLines.Length];
            
            Console.WriteLine("Comparing files...");

            for (int index = 0; index < actualOutputLines.Length; index++)
            {
                string actualLine = actualOutputLines[index];
                string expectedLine = expectedOutputLines[index];

                if (!actualLine.Equals(expectedLine))
                {
                    output =  $"Mismatch at line {index} -- expected: \"{expectedLine}\", actual: \"{actualLine}\"{Environment.NewLine}";
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }
                mismatches[index] = output;
            }
            return mismatches;
        }

        private static string GetMismatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }
    }
}

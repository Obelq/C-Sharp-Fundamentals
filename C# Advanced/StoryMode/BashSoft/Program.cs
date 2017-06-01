using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOManager.TraverseDirectory(@"C:\Users\Georgi\Documents\GitHub\C-Sharp-Fundamentals\C# Advanced\1. SetsAndDictionariesLab");
            
            //StudentRepository.InitializeData();
            //StudentRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            IOManager.TraverseDirectory(20);
        }
    }
}

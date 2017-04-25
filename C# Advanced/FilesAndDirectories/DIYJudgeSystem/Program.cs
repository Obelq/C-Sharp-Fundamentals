using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYJudgeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tester.CompareContent(@"..\..\test2.txt", @"..\..\test3.txt");
            //IOManager.CreateDirectoryInCurrentFolder("pesho");
            IOManager.TraverseDirectory(4);
        }
    }
}

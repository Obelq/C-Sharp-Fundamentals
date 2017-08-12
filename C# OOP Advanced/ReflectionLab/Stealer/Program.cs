using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        //string result = spy.StealFieldInfo("Hacker", "username", "password");
        //var result = spy.AnalyzeAcessModifiers("Hacker");
        //var result = spy.RevealPrivateMethods("Hacker");
        var result = spy.CollectGettersAndSetters("Hacker");

        Console.WriteLine(result);
    }
}


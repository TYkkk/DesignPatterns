using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns_DecoratorPattern.DecoratorPattern a = new DesignPatterns_DecoratorPattern.DecoratorPattern();
            a.Run();
            Console.ReadLine();
        }
    }
}

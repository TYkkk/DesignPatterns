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
            BuilderPattern builderPattern = new BuilderPattern();
            builderPattern.Create();

            Console.ReadLine();
        }
    }
}

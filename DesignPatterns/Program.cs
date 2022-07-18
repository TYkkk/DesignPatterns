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
            DesignPatterns_AdapterPattern.AdapterPattern a = new DesignPatterns_AdapterPattern.AdapterPattern();
            a.Run();
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns_AbstractFactory.AbstractFactory abstractFactory = new DesignPatterns_AbstractFactory.AbstractFactory();
            abstractFactory.Run();
        }
    }
}
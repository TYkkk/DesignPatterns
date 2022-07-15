using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_BuilderPattern
{
    class BuilderPattern
    {
        public void Create()
        {
            WindowsComputerBuilder windowsComputerBuilder = new WindowsComputerBuilder();
            Console.WriteLine(windowsComputerBuilder.CreateProduct().DebugConfig());

            MacComputerBuilder macComputerBuilder = new MacComputerBuilder();
            Console.WriteLine(macComputerBuilder.CreateProduct().DebugConfig());
        }
    }

    abstract class Product
    {
        public abstract string DebugConfig();
    }

    abstract class Builder
    {
        public abstract Product CreateProduct();
    }

    abstract class ComputerBuilder : Builder
    {
        protected Computer computer = new Computer();

        protected abstract void BuildCPU();

        protected abstract void BuildGPU();

        public override Product CreateProduct()
        {
            BuildCPU();
            BuildGPU();
            return computer;
        }
    }

    class WindowsComputerBuilder : ComputerBuilder
    {
        protected override void BuildCPU()
        {
            computer.CPU = "Windows_CPU";
        }

        protected override void BuildGPU()
        {
            computer.GPU = "Windows_GPU";
        }
    }

    class MacComputerBuilder : ComputerBuilder
    {
        protected override void BuildCPU()
        {
            computer.CPU = "MAC_CPU";
        }

        protected override void BuildGPU()
        {
            computer.GPU = "MAC_GPU";
        }
    }

    class Computer : Product
    {
        public string CPU;
        public string GPU;

        public override string DebugConfig()
        {
            return $"Computer CPU:{CPU},GPU:{GPU}";
        }
    }
}

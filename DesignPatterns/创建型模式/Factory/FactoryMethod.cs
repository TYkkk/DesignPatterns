using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_FactoryMethod
{
    class SimplyFactory
    {
        public Product CreateProduct(string type)
        {
            switch (type)
            {
                case "Phone":
                    return new Phone();
                case "Computer":
                    return new Computer();
                default:
                    return null;
            }
        }
    }

    abstract class FactoryMethod_Factory
    {
        public abstract Product CreateProduct();
    }

    class FactoryMethod_PhoneFactory : FactoryMethod_Factory
    {
        public override Product CreateProduct()
        {
            return new Phone();
        }
    }

    class FactoryMethod_ComputerFactory : FactoryMethod_Factory
    {
        public override Product CreateProduct()
        {
            return new Computer();
        }
    }

    class Product
    {

    }

    class Phone : Product
    {
        public void Call(string number) { }
    }

    class Computer : Product
    {
        public void Run() { }
    }
}
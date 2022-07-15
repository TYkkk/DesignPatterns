using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract Product CreatePhone();

        public abstract Product CreateComputer();
    }

    class WindowsFactory : AbstractFactory
    {
        public override Product CreatePhone()
        {
            return new WindowsPhone();
        }

        public override Product CreateComputer()
        {
            return new WindowsComputer();
        }
    }

    class IOSFactory : AbstractFactory
    {
        public override Product CreatePhone()
        {
            return new IOSPhone();
        }

        public override Product CreateComputer()
        {
            return new IOSComputer();
        }
    }

    class Product
    {

    }

    class Phone : Product
    {

    }

    class Computer : Product
    {

    }

    class WindowsPhone : Phone
    {

    }

    class IOSPhone : Phone
    {

    }

    class WindowsComputer : Computer
    {

    }

    class IOSComputer : Computer
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_AdapterPattern
{
    class AdapterPattern
    {
        public void Run()
        {
            ITarget target = new AdapterTarget();
            target.Method();
        }
    }

    interface ITarget
    {
        void Method();
    }

    public class Target : ITarget
    {
        public virtual void Method()
        {

        }
    }

    public class Current
    {
        public void Debug()
        {
            Console.Write("Current Debug");
        }
    }

    public class AdapterCurrent : Current, ITarget
    {
        public void Method()
        {
            Debug();
        }
    }

    public class AdapterTarget : Target
    {
        private Current current = new Current();

        public override void Method()
        {
            current.Debug();
        }
    }
}

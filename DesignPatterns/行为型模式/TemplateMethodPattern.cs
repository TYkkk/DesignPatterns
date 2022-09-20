using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_TemplateMethodPattern
{
    class TemplateMethodPattern
    {
        public void Run()
        {
            BaseMethod method = new Method01();
            method.DoMethod();
        }
    }

    public abstract class BaseMethod
    {
        public void DoMethod()
        {
            ChildMethod01();
            ChildMethod02();
            ChildMethod03();
        }

        public abstract void ChildMethod01();
        public abstract void ChildMethod02();
        public abstract void ChildMethod03();
    }

    public class Method01 : BaseMethod
    {
        public override void ChildMethod01()
        {
        }

        public override void ChildMethod02()
        {
        }

        public override void ChildMethod03()
        {
        }
    }

    public class Method02 : BaseMethod
    {
        public override void ChildMethod01()
        {
        }

        public override void ChildMethod02()
        {
        }

        public override void ChildMethod03()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_DecoratorPattern
{
    class DecoratorPattern
    {
        public void Run()
        {
            Phone p = new ApplePhone();
            Decorator sticker = new Sticker(p);
            sticker.Print();

            Decorator acc = new Accessories(sticker);
            acc.Print();
        }
    }

    public abstract class Phone
    {
        public abstract void Print();
    }

    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.Write("这是ApplePhone");
        }
    }

    public abstract class SystemFunction : Phone
    {
        private Phone phone;

        public SystemFunction(Phone p)
        {
            phone = p;
        }

        public override void Print()
        {
            if (phone == null)
                return;
            phone.Print();
            Console.WriteLine("这是系统功能");
        }
    }

    public class Call : SystemFunction
    {
        public Call(Phone p) : base(p)
        {
        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("增加了打电话功能");
        }
    }

    public abstract class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone p)
        {
            phone = p;
        }

        public override void Print()
        {
            if (phone == null)
                return;
            phone.Print();
            Console.WriteLine("这是装饰Decorator");
        }
    }

    public class Sticker : Decorator
    {
        public Sticker(Phone p) : base(p)
        {

        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("增加了贴膜");
        }
    }

    public class Accessories : Decorator
    {
        public Accessories(Phone p) : base(p)
        {

        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("增加了挂件");
        }
    }
}

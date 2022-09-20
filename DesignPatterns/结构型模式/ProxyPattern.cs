using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_ProxyPattern
{
    class ProxyPattern
    {
        public void Run()
        {
            Proxy proxy = new Proxy();
            proxy.Func();
        }
    }

    interface IFunc
    {
        void Func();
    }

    public class Proxy : IFunc
    {
        private Real real;

        public Proxy()
        {
            real = new Real();
        }

        public void Func()
        {
            real.Func();
        }
    }

    public class Real : IFunc
    {
        public void Func()
        {
        }
    }
}

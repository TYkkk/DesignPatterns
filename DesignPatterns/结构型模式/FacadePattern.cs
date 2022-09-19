using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_FacadePattern
{
    class FacadePattern
    {
        public void Run()
        {
            //Before
            SubSystem01 subSystem01 = new SubSystem01();
            SubSystem02 subSystem02 = new SubSystem02();
            subSystem01.RunMethod();
            subSystem02.RunMethod();

            //After
            FacadeSystem facadeSystem = new FacadeSystem();
            facadeSystem.RunSystemMethod();
        }
    }

    public class SubSystem01
    {
        public void RunMethod()
        {
            Console.Write("Run SubSystem01");
        }
    }

    public class SubSystem02
    {
        public void RunMethod()
        {
            Console.Write("Run SubSystem02");
        }
    }

    public class FacadeSystem
    {
        public void RunSystemMethod()
        {
            SubSystem01 subSystem01 = new SubSystem01();
            SubSystem02 subSystem02 = new SubSystem02();
            subSystem01.RunMethod();
            subSystem02.RunMethod();
        }
    }
}

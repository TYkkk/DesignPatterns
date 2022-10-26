using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_CommandPattern
{
    class CommandPattern
    {
    }

    public interface ICommand
    {
        void Execute();
    }

    public class CommandMethod01 : ICommand
    {
        Receive receive;

        public CommandMethod01(Receive receive)
        {
            this.receive = receive;
        }

        public void Execute()
        {
            receive.DoCommand01();
        }
    }

    public class CommandMethod02 : ICommand
    {
        Receive receive;

        public CommandMethod02(Receive receive)
        {
            this.receive = receive;
        }

        public void Execute()
        {
            receive.DoCommand02();
        }
    }

    public class Control
    {
        private ICommand command01, command02;
        public Control(ICommand command01, ICommand command02)
        {
            this.command01 = command01;
            this.command02 = command02;
        }

        public void DoCommand01()
        {
            command01.Execute();
        }

        public void DoCommand02()
        {
            command02.Execute();
        }
    }

    public class Receive
    {
        public void DoCommand01() { }
        public void DoCommand02() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_FactoryMethod
{
    class FactoryMethod
    {
        public void Run()
        {
            Dialog windowsDialog = new WindowsDialog();
            Console.WriteLine(windowsDialog.CreateButton().Print());

            Dialog macDialog = new MacDialog();
            Console.WriteLine(macDialog.CreateButton().Print());
        }
    }

    abstract class Dialog
    {
        public abstract Button CreateButton();
    }

    abstract class Button
    {
        public abstract string Print();
    }

    class WindowsDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }
    }

    class WindowsButton : Button
    {
        public override string Print()
        {
            return "this is WindowsButton";
        }
    }

    class MacDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }
    }

    class MacButton : Button
    {
        public override string Print()
        {
            return "this is MacButton";
        }
    }
}

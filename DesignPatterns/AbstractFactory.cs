using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_AbstractFactory
{
    class AbstractFactory
    {
        public void Run()
        {
            Dialog windowsDialog = new WindowsDialog();
            windowsDialog.Run();

            Dialog macDialog = new MacDialog();
            macDialog.Run();
        }
    }

    abstract class Dialog
    {
        public abstract Button CreateButton();
        public abstract Image CreateImage();

        public void Run()
        {
            Button button = CreateButton();
            Console.WriteLine(button.Print());

            Image img = CreateImage();
            Console.WriteLine(img.Print());
        }
    }

    abstract class Button
    {
        public abstract string Print();
    }

    abstract class Image
    {
        public abstract string Print();
    }

    class WindowsDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override Image CreateImage()
        {
            return new WindowsImage();
        }
    }

    class MacDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }

        public override Image CreateImage()
        {
            return new MacImage();
        }
    }

    class WindowsButton : Button
    {
        public override string Print()
        {
            return "this is WindowsButton";
        }
    }

    class MacButton : Button
    {
        public override string Print()
        {
            return "this is MacButton";
        }
    }

    class WindowsImage : Image
    {
        public override string Print()
        {
            return "this is WindowsImage";
        }
    }

    class MacImage : Image
    {
        public override string Print()
        {
            return "this is MacImage";
        }
    }
}

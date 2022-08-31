using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_CompositePattern
{
    class CompositePattern
    {
        public void Run()
        {
            Node root = new Folder();
            Node file = new File();
            (root as Folder).Add(file);
            root.DoubleClick();
            file.DoubleClick();
        }
    }

    abstract class Node
    {
        public abstract void DoubleClick();
    }

    class Folder : Node
    {
        public List<Node> ChildNodes = new List<Node>();
        public override void DoubleClick()
        {
            Console.Write("Show Folder Child Content");
        }

        public void Add(Node node)
        {
            ChildNodes.Add(node);
        }

        public void Remove(Node node)
        {
            ChildNodes.Remove(node);
        }
    }

    class File : Node
    {
        public override void DoubleClick()
        {
            Console.Write("Show File Content");
        }
    }
}

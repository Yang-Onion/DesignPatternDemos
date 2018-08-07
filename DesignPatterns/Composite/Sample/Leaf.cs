using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Sample
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component compnent)
        {
            Console.WriteLine("add a leaf to component");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(string.Empty.PadLeft(depth,'-')+name);
        }

        public override void Remove(Component compnent)
        {
            Console.WriteLine("remove a leaf from component");
        }
    }
}

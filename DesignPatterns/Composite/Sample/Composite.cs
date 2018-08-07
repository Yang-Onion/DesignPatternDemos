using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Sample
{
    public class Composite : Component
    {
        private List<Component> compnentList = new List<Component>();

        public Composite(string name) : base(name)
        {

        }
        public override void Add(Component compnent)
        {
            compnentList.Add(compnent);
        }

        public override void Remove(Component compnent)
        {
            compnentList.Remove(compnent);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(string.Empty.PadLeft(depth, '-') + name);

            foreach (Component component in compnentList)
            {
                component.Display(depth + 2);
            }
        }
    }
}

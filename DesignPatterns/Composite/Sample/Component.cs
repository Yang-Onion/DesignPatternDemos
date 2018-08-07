using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Sample
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component compnent);
        public abstract void Remove(Component compnent);

        public abstract void Display(int depth);
    }
}

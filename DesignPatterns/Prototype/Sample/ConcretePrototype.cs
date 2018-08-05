using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Sample
{
    public class ConcretePrototype : AbstractPrototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override AbstractPrototype Clone()
        {
            return (AbstractPrototype)this.MemberwiseClone();
        }
    }
}

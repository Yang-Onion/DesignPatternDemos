using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Sample
{
    public abstract class AbstractPrototype
    {
        public string Id { get; set; }

        public AbstractPrototype(string id)
        {
            Id = id;
        }

        public abstract AbstractPrototype Clone();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Sample
{
    public abstract class FlyWeight
    {
        public abstract string Id { get; }
        public abstract void Operation(int instance);

    }
}

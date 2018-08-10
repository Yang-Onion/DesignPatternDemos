using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Sample
{
    public class ConcreteFlyWeight : FlyWeight
    {
        public override string Id => Guid.NewGuid().ToString();

        public override void Operation(int instance)
        {
            Console.WriteLine($"ConcreteFlyWeight~~~~{instance}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Sample
{
    public class UnShareConcreteFlyWeight : FlyWeight
    {
        public override string Id => Guid.NewGuid().ToString();

        public override void Operation(int instance)
        {
            Console.WriteLine($"UnshareConcreteFlyWeight.......{instance}");

        }
    }
}

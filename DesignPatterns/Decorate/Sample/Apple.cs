using System;
using System.Collections.Generic;
using System.Text;

namespace Decorate.Sample
{
    /// <summary>
    /// ConcreteComponent
    /// </summary>
    public class Apple : Phone
    {
        public override void Print()
        {
            Console.WriteLine("Apple Phone (Concrete Component)");
        }
    }
}

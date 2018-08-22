using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public class Computer : Element
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutComputer(this);
        }
    }
}

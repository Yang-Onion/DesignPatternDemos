using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public abstract class Element
    {
        public abstract void Operate(Visitor visitor);

        public int Size { get; set; }
        public int State { get; set; }
    }
}

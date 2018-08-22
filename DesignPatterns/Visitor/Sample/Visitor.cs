using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public abstract class Visitor
    {
        public abstract void PutTelevision(Television tv);
        public abstract void PutComputer(Computer computer);
    }
}

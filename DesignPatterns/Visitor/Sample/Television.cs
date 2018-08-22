using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public class Television : Element
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutTelevision(this);
        }
    }
}

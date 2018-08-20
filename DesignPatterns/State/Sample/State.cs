using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public abstract class State
    {
        public abstract void Process(Order order);

    }
}

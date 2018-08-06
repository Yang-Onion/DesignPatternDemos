using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Sample
{
    public class MultiOperation:Operation
    {
        public override double Caculate()
        {
            double result = First * Second;
            return result;
        }
    }
}

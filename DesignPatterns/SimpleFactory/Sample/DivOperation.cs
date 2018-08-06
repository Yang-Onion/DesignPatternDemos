using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Sample
{
    public class DivOperation:Operation
    {
        public override double Caculate()
        {
            double result = 0d;
            if (Second ==0)
            {
                throw new DivideByZeroException("除数不能为0");
            }
            result = First / Second;
            return result;
        }
    }
}

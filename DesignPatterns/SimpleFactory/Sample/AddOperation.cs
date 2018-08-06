using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Caculator
{
    public class AddOperation:Operation
    {
        public override double Caculate()
        {
            double result = First + Second;

            return result;
        }
    }
}

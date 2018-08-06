using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Caculator
{
    public class Operation
    {
        public double First { get; set; }
        public double Second { get; set; }

        public virtual double Caculate()
        {
            double result = 0d;
            return result;
        }
    }
}

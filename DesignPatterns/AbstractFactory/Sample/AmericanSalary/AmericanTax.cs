using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary.AmericanSalary
{
    public class AmericanTax:Tax
    {
        public override double Caculate()
        {
            return (Constant.BASE_SALARY * 5 / 100 + Constant.BASE_SALARY * 25 / 100);
        }
    }
}

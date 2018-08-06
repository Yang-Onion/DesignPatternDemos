using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Sample.AmericanSalary
{
    public class AmericanBonus:Bonus
    {
        public override double Caculate()
        {
            return Constant.BASE_SALARY * 0.15;
        }
    }
}

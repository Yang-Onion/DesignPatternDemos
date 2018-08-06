using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary.ChineseSalary
{
    public class ChineseBonus:Bonus
    {
        public override double Caculate()
        {
            return Constant.BASE_SALARY * 0.1;
        }
    }
}

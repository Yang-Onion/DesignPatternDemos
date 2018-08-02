using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary.ChineseSalary
{
    public class ChineseTax:Tax
    {
        public override double Caculate()
        {
            return (Constant.BASE_SALARY + Constant.BASE_SALARY * 0.1) * 0.4;
        }
    }
}

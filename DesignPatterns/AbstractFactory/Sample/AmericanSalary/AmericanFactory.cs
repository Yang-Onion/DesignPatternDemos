using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary.AmericanSalary
{
    public class AmericanFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new AmericanBonus();
        }

        public override Tax CreateTax()
        {
            return new AmericanTax();
        }
    }
}

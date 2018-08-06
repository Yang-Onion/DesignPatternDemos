using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Sample.AmericanSalary
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

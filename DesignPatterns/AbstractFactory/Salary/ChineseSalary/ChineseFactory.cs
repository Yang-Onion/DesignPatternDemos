﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary.ChineseSalary
{
    public class ChineseFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new ChineseBonus();
        }

        public override Tax CreateTax()
        {
            return new ChineseTax();
        }
    }
}

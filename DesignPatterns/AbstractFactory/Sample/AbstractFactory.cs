using AbstractFactory.Salary.AmericanSalary;
using AbstractFactory.Salary.ChineseSalary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Salary
{
    public  abstract class AbstractFactory
    {
        public static AbstractFactory GetInstance(string concreteFactoryName)
        {
            AbstractFactory factory=null;
            switch (concreteFactoryName)
            {
                case "AmericanFactory":
                    factory=  new AmericanFactory();
                    break;
                case "ChineseFactory":
                    factory = new ChineseFactory();
                    break;
                default:
                    break;
            }
            return factory;
        }
        public abstract Bonus CreateBonus();

        public abstract Tax CreateTax();
    }
}

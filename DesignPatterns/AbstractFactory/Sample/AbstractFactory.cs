using AbstractFactory.Sample.AmericanSalary;
using AbstractFactory.Sample.ChineseSalary;

namespace AbstractFactory.Sample
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

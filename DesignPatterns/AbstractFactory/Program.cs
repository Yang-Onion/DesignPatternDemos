using System;
using AbstractFactory.Sample;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = Sample.AbstractFactory.GetInstance(Constant.FACTORY_NAME);
            var bonus = factory.CreateBonus().Caculate();
            var tax = factory.CreateTax().Caculate();

            var salary = Constant.BASE_SALARY + bonus - tax;

            Console.WriteLine($"Total Salary is :{salary}");

            Console.Read();
        }
    }
}

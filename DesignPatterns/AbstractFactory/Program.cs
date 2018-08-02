using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = Salary.AbstractFactory.GetInstance(Salary.Constant.FACTORY_NAME);
            var bonus = factory.CreateBonus().Caculate();
            var tax = factory.CreateTax().Caculate();

            var salary = Salary.Constant.BASE_SALARY + bonus - tax;

            Console.WriteLine($"Total Salary is :{salary}");

            Console.Read();
        }
    }
}

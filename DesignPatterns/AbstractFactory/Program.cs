using System;
using AbstractFactory.Sample;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.AbstractFactory factory = new Sample.ChineseSalary.ChineseFactory();
            var bonus = factory.CreateBonus().Caculate();
            var tax = factory.CreateTax().Caculate();

            var salary = Constant.BASE_SALARY + bonus - tax;

            Console.WriteLine($"Total Salary is :{salary}");

            Console.Read();
        }
    }
}

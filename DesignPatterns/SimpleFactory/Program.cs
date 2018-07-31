using SimpleFactory.Caculator;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = CaculateFactory.CreateOperation("*");
            operation.First = 2;
            operation.Second = 5;
            double result = operation.Caculate();
            Console.WriteLine($"Result:{result}");
            Console.ReadKey();

        }
    }
}

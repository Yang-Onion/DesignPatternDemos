using System;

namespace Interator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Interator interator;

            Sample.Aggregate aggregate = new Sample.ConcreteAggregate();

            interator = aggregate.GetInterator();

            while (interator.MoveNext())
            {
                string soldier = (string)interator.GetCurrent();
                Console.WriteLine(soldier);
                interator.Next();
            }

            Console.Read();
        }
    }
}

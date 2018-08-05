using Prototype.Sample;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractPrototype = new ConcretePrototype(System.Guid.NewGuid().ToString());
            var cloneType = abstractPrototype.Clone() as ConcretePrototype;

            Console.WriteLine("Cloned1:\t" + cloneType.Id);


            var cloneType2 = abstractPrototype.Clone() as ConcretePrototype;

            Console.WriteLine("Cloned2:\t" + cloneType.Id);

            Console.Read();
        }
    }
}

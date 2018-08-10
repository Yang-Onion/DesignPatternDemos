using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int instance = 100;

            Sample.FlyWeightFactory flyWeightFactory = new Sample.FlyWeightFactory();

            var key1 = Guid.NewGuid().ToString("N");
            Sample.FlyWeight flyWeight1 =flyWeightFactory.CreateFlyWeight(key1);
            flyWeight1.Operation(--instance);

            var key2 = Guid.NewGuid().ToString("N");
            Sample.FlyWeight flyWeight2 = flyWeightFactory.CreateFlyWeight(key2);
            flyWeight2.Operation(--instance);

            Sample.FlyWeight flyWeight3 = flyWeightFactory.CreateFlyWeight(key1);
            flyWeight3.Operation(--instance);

            Sample.UnShareConcreteFlyWeight unShareConcreteFlyWeight = new Sample.UnShareConcreteFlyWeight();
            unShareConcreteFlyWeight.Operation(--instance);


            Console.Read();
        }
    }
}

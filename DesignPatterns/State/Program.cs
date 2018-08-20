using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Order order = new Sample.Order();

            order.Minute = 10;
            order.Action();

            order.IsCanceled = true;
            order.Minute = 20;
            order.Action();

            order.Minute = 31;
            order.Action();

            order.Minute = 50;
            order.Action();


            Console.Read();

        }
    }
}

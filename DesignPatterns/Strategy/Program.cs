using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Strategy strategy = new Sample.WeChatPayStrategy();
            Sample.Context context = new Sample.Context(strategy);
            context.Pay(200);


            Console.Read();
        }
    }
}

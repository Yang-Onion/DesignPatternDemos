using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Receiver receiver = new Sample.Receiver();
            Sample.Command command = new Sample.ConcreteCommand(receiver);
            Sample.Invoker invoker = new Sample.Invoker(command);

            invoker.ExecuteCommand();

            Console.Read();
        }
    }
}

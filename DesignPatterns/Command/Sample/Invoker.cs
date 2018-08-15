using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Sample
{
    public class Invoker
    {
        private Command _command;
        public Invoker(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Invoker 发布任务....");
            _command.MakeDumpling();
        }
    }
}

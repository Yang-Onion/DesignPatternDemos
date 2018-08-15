using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Sample
{
    public class Receiver
    {
        public void Execute(string task)
        {
            Console.WriteLine($"Receiver  执行任务:{task}");
        }
    }
}

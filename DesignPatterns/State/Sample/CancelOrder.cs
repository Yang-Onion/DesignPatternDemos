using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class CancelOrder : State
    {
        public override void Process(Order order)
        {
            Console.WriteLine("货物如果有问题,请拒绝签收!");
            order.TaskFinished = false;
        }
    }
}

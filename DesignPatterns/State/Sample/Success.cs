using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class Success : State
    {
        public override void Process(Order order)
        {
            Console.WriteLine("订单结算");
            order.TaskFinished = true;
        }
    }
}

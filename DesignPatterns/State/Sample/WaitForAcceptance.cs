using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class WaitForAcceptance : State
    {
        public override void Process(Order order)
        {
            Console.WriteLine("我们开始受理，准备备货！");
            if (order.Minute<=30 && order.IsCanceled)
            {
                Console.WriteLine("30分钟内可以退货..");

                order.SetState(new CancelOrder());

                order.Action();
            }

            order.SetState(new AcceptAndDeliver());
            order.TaskFinished = false;
            order.Action();
        }
    }
}

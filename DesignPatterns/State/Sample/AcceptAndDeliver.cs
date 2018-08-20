using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class AcceptAndDeliver : State
    {
        public override void Process(Order order)
        {
            Console.WriteLine("我们开始准备发货..");
            if (order.Minute<=30 && order.IsCanceled)
            {
                Console.WriteLine("30分钟内可以取消订单..");

                order.SetState(new CancelOrder());
                order.TaskFinished = true;
                order.Action();
            }
            if (!order.TaskFinished)
            {
                order.SetState(new ConfirmationReceipt());
                order.Action();
            }

            
        }
    }
}

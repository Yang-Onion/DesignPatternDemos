using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class ConfirmationReceipt : State
    {
        public override void Process(Order order)
        {
            Console.WriteLine("请仔细检查货物，确认没问题后签收!");

            order.SetState(new Success());
            order.TaskFinished = false;
            order.Action();
        }
    }
}

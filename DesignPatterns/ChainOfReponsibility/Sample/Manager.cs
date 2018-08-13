using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility.Sample
{
    /// <summary>
    /// 具体审核人-总经理
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {

        }
        public override void Process(ApplyForLeaveRequest request)
        {
            if (request.Days>3)
            {
                Console.WriteLine($"请假{request.Days}天,总经理{ApproverName}意见:同意！");
            }
        }
    }
}

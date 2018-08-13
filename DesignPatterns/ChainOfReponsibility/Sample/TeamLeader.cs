using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility.Sample
{
    /// <summary>
    /// 具体的审批人-组长
    /// </summary>
    public class TeamLeader : Approver
    {
        public TeamLeader(string name) : base(name)
        {

        }

        public override void Process(ApplyForLeaveRequest request)
        {
            if (request.Days<=1)
            {
                Console.WriteLine($"请假{request.Days}天,组长{ApproverName}意见:同意!");
            }
            else
            {
                if (NexApprover !=null)
                {
                    NexApprover.Process(request);
                }
            }
        }
    }
}

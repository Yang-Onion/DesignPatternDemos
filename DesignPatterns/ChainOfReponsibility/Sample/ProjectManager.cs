using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility.Sample
{
    /// <summary>
    ///具体审核人-项目经理
    /// </summary>
    public class ProjectManager : Approver
    {
        public ProjectManager(string name) : base(name)
        {

        }

        public override void Process(ApplyForLeaveRequest request)
        {
            if (1<request.Days && request.Days<=3)
            {
                Console.WriteLine($"请假{request.Days}天,项目经理{ApproverName}意见:同意!");
            }
            else
            {
                if (NexApprover != null)
                {
                    NexApprover.Process(request);
                }
            }
        }
    }
}

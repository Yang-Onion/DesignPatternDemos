using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility.Sample
{
    /// <summary>
    /// 抽象审核人
    /// </summary>
    public abstract class Approver
    {
        public Approver NexApprover { get; set; }
        public string ApproverName { get; set; }

        public Approver(string approverName)
        {
            ApproverName = approverName;
        }

        public abstract void Process(ApplyForLeaveRequest request);
    }
}

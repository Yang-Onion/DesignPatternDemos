using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility.Sample
{
    /// <summary>
    /// 请假流程
    /// </summary>
    public class ApplyForLeaveRequest
    {
        public string EmployeeName { get; set; }

        public double Days { get; set; }

        public ApplyForLeaveRequest(string employeeName,double days)
        {
            EmployeeName = employeeName;
            Days = days;
        }
    }
}

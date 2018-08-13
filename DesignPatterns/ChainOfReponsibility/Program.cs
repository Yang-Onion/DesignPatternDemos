using ChainOfReponsibility.Sample;
using System;

namespace ChainOfReponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            ApplyForLeaveRequest halfDay = new ApplyForLeaveRequest("Yang-Onion", 0.5D);
            ApplyForLeaveRequest twoDays = new ApplyForLeaveRequest("Yang@Onion", 2D);
            ApplyForLeaveRequest sevenDays = new ApplyForLeaveRequest("Yang-Onion@github.com", 7D);


            TeamLeader teamLeader = new TeamLeader("赵云");
            ProjectManager projectManager = new ProjectManager("诸葛亮");
            Manager manager = new Manager("刘备");

            teamLeader.NexApprover = projectManager;
            projectManager.NexApprover = manager;

            teamLeader.Process(halfDay);
            teamLeader.Process(twoDays);
            teamLeader.Process(sevenDays);

            Console.Read();

        }
    }
}

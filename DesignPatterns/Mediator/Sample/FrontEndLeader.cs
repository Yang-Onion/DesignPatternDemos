using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Sample
{
    public class FrontEndLeader : Employee
    {
        public FrontEndLeader(IMediator mediator) : base(mediator)
        {

        }
        public override void Communicate()
        {
            Console.WriteLine("后端API接口老是有问题.....");
        }

        public override void Process()
        {
            Console.WriteLine("开发前端界面....");
            Mediator.Command(this);
        }
    }
}

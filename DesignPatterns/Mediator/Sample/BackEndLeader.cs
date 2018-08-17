using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Sample
{
    public class BackEndLeader : Employee
    {
        public BackEndLeader(IMediator mediator) : base(mediator)
        {

        }
        public override void Communicate()
        {
            Console.WriteLine("前端调API的时候不按规定传参数....");
            
        }

        public override void Process()
        {
            Console.WriteLine("开发后端API...");

            Mediator.Command(this);
        }
    }
}

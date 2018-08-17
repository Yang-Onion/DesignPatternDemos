using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.ProjecAssistant mediator = new Sample.ProjecAssistant();

            Sample.FrontEndLeader frontEndLeader = new Sample.FrontEndLeader(mediator);
            Sample.BackEndLeader backEndLeader = new Sample.BackEndLeader(mediator);

            mediator.SetBackEndLeader(backEndLeader);
            mediator.SetFrontEndLeader(frontEndLeader);


            frontEndLeader.Process();

            backEndLeader.Process();

            
            Console.Read();
            
        }
    }
}

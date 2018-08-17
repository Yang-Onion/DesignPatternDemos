using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Sample
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjecAssistant : IMediator
    {
        private  FrontEndLeader _frontEndLeader;
        private  BackEndLeader _backEndLeader;


        public void SetFrontEndLeader(FrontEndLeader frontEndLeader)
        {
            _frontEndLeader = frontEndLeader;
        }

        public void SetBackEndLeader(BackEndLeader backEndLeader)
        {
            _backEndLeader = backEndLeader;
        }

        public void Command(Employee employee)
        {
            //if (employee is FrontEndLeader)
            //{
            //    _frontEndLeader.Communicate();

            //}
            //if (employee is BackEndLeader)
            //{
            //    _backEndLeader.Communicate();
            //}
            employee.Communicate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Sample
{
    public abstract class Employee
    {
        private IMediator mediator;
        public Employee(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public IMediator Mediator
        {
            get { return mediator; }
            private set { this.mediator = value; }
        }

        public abstract void Process();
        public abstract void Communicate();
    }
}

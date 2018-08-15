using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Sample
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }
        public override void MakeDumpling()
        {
            var task = "包饺子";

            _receiver.Execute(task);
        }
    }
}

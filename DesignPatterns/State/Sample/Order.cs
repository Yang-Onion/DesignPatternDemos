using System;
using System.Collections.Generic;
using System.Text;

namespace State.Sample
{
    public class Order
    {
        private State current;
        public Order()
        {
            current = new WaitForAcceptance();

        }

        public double Minute { get; set; }
        public bool IsCanceled { get; set; }

        public bool TaskFinished { get; set; }

        public void SetState(State state)
        {
            current = state;
        }

        public void Action()
        {
            current.Process(this);
        }
    }

}

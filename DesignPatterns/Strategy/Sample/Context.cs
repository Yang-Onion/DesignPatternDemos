using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sample
{
    public class Context
    {
        private Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Pay(decimal money)
        {
            if (strategy !=null)
            {
                strategy.Pay(money);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Sample
{
    public class ABCMessageSystem : BankMessageSystem
    {
        public override void Add(Depositor depositor)
        {
            if(!observerList.Contains(depositor))
            {
                observerList.Add(depositor);
            }
            
        }

        public override void Remove(Depositor depositor)
        {
            if (observerList.Contains(depositor))
            {
                observerList.Remove(depositor);
            }
            
        }
    }
}

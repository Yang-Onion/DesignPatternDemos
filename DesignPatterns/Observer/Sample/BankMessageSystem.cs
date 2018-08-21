using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Sample
{
    public abstract class BankMessageSystem
    {
        protected List<Depositor> observerList;
        
        public BankMessageSystem()
        {
            observerList = new List<Depositor>();
        }

        public abstract void Add(Depositor depositor);

        public abstract void Remove(Depositor depositor);

        public void Notify()
        {
            foreach (var observer in observerList)
            {
                if (observer !=null && observer.IsChanged)
                {
                    observer.Update(observer.Balance, DateTime.Now);
                    observer.IsChanged = false;
                }
            }
        }
    }
}

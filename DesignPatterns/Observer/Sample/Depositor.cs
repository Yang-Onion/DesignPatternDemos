using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Sample
{
    public abstract class Depositor
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal Total { get; set; }
        public bool IsChanged { get; set; }
        public DateTime OperateTime { get; set; }

        public Depositor(string name,decimal total)
        {
            Name = name;
            Balance = total;
            IsChanged = false;
        }
        
        public void GetMoeny(decimal money)
        {
            if (money<Balance && money>0)
            {
                Balance = Balance - money;
                IsChanged = true;
                OperateTime = DateTime.Now;
            }
        }

        public abstract void Update(decimal currentBalance, DateTime operateTime);
    }
}

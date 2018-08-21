using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Sample
{
    /// <summary>
    /// 中国银行
    /// </summary>
    public class ABC : Depositor
    {
        public ABC(string name,decimal total) : base(name, total)
        {

        }
        public override void Update(decimal currentBalance, DateTime operateTime)
        {
            Console.WriteLine($"{Name}:账户发生了变化,{operateTime.ToString()},当前账户余额是:{currentBalance}");
        }
    }
}

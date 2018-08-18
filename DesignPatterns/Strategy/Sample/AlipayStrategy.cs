using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sample
{
    public class AlipayStrategy : Strategy
    {
        public override void Pay(decimal money)
        {
            Console.WriteLine($"支付宝支付{money}元");
        }
    }
}

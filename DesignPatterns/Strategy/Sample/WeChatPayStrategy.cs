using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sample
{
    public class WeChatPayStrategy : Strategy
    {
        public override void Pay(decimal money)
        {
            Console.WriteLine($"微信支付{money}元");
        }
    }
}

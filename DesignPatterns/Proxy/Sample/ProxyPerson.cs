using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Sample
{
    public class ProxyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("proxy:请帮我代购N罐奶粉...");
        }
    }
}

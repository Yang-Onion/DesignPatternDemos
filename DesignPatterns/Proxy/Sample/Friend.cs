using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Sample
{
    public class Friend : Person
    {
        ProxyPerson proxyPerson;
        public override void BuyProduct()
        {
            if (proxyPerson==null)
            {
                proxyPerson = new ProxyPerson();
            }

            PreProduct();
            
            //调用代理类
            proxyPerson.BuyProduct();

            PostProduct();
        }

        private void PreProduct()
        {
            Console.WriteLine("需购买奶粉清单.美赞臣5罐.美素佳儿10罐。");
        }

        private void PostProduct()
        {
            Console.WriteLine("邮寄奶粉...");
        }
    }
}

using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Friend friend = new Sample.Friend();
            friend.BuyProduct();

            Console.Read();
        }
    }
}

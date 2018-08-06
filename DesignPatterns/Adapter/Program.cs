using Adapter.Sample;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:类适配器
            ISocket socket = new SocketAdapter();
            socket.GetElectric();

            //2:对象适配器
            BaseSocket baseSocket = new ChinaSocketAdpter();
            baseSocket.GetElectric();

            Console.Read();


        }
    }
}

using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.ABC yang = new Sample.ABC("Yang-Onion", 10000);
            Sample.ABC lee = new Sample.ABC("lee", 860);
            Sample.ABC zhang = new Sample.ABC("zhang", 30000);

            Sample.BankMessageSystem ABCMessageSystem = new Sample.ABCMessageSystem();
            ABCMessageSystem.Add(yang);
            ABCMessageSystem.Add(lee);
            ABCMessageSystem.Add(zhang);

            yang.GetMoeny(300);
            ABCMessageSystem.Notify();

            lee.GetMoeny(60);
            zhang.GetMoeny(3000);
            ABCMessageSystem.Notify();

            Console.Read();

        }
    }
}

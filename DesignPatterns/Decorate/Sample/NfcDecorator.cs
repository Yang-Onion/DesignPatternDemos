using System;
using System.Collections.Generic;
using System.Text;

namespace Decorate.Sample
{
    public  class NfcDecorator:Decorator
    {
        public NfcDecorator(Phone phone) : base(phone)
        {

        }
        public override void Print()
        {
            base.Print();

            AddNFC();
        }

        private void AddNFC()
        {
            Console.WriteLine("your phone had nfc function...");
        }
    }
}

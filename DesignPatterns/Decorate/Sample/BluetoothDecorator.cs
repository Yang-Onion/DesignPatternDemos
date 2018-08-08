using System;
using System.Collections.Generic;
using System.Text;

namespace Decorate.Sample
{
    public class BluetoothDecorator:Decorator
    {
        public BluetoothDecorator(Phone phone) : base(phone)
        {

        }

        public override void Print()
        {
            base.Print();
            AddBlueTooth();
        }

        private void AddBlueTooth()
        {
            Console.WriteLine("your phone has bluetooth function...");
        }
    }
}

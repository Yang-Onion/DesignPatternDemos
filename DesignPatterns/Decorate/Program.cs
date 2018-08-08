using Decorate.Sample;
using System;

namespace Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Apple();

            NfcDecorator nfcDecorator = new NfcDecorator(phone);
            nfcDecorator.Print();

            Console.WriteLine("\t");

            BluetoothDecorator bluetoothDecorator = new BluetoothDecorator(nfcDecorator);
            bluetoothDecorator.Print();


            Console.Read();
        }
    }
}

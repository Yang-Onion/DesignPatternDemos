using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.RemoteControl remoteControl = new Sample.SonyRemoteControl();

            remoteControl.Implementor = new Sample.Sony();

            remoteControl.On();
            remoteControl.Off();
            remoteControl.ChangChanel();

            Sample.RemoteControl changhongRemoteControl = new Sample.ChanghongRemoteControl();
            remoteControl.Implementor = new Sample.Changhong();

            remoteControl.On();
            remoteControl.Off();
            remoteControl.ChangChanel();


            Console.Read();
        }
    }
}

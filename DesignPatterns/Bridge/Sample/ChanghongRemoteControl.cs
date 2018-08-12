using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    public class ChanghongRemoteControl:RemoteControl
    {
        public override void ChangChanel()
        {
            Console.WriteLine("-----Changhong-strart-----");
            base.ChangChanel();
            Console.WriteLine("-----Changhong-end-----");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    /// <summary>
    /// Refined Abstraction
    /// 扩展抽象化角色，改变和修正父类对抽象化的定义
    /// </summary>
    public class SonyRemoteControl:RemoteControl
    {
        public override void ChangChanel()
        {
            Console.WriteLine("-----sony-start-----");
            base.ChangChanel();
            Console.WriteLine("-----sony-end-----");
        }
    }
}

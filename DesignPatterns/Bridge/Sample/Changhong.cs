using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class Changhong : TV
    {
        public override void ChangeChannel()
        {
            Console.WriteLine("Changhong changechannel...");
        }

        public override void Off()
        {
            Console.WriteLine("Changhong turn off...");
        }

        public override void On()
        {
            Console.WriteLine("Changhong turn on...");
        }
    }
}

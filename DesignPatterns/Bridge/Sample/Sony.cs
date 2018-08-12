using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class Sony:TV
    {
        public override void ChangeChannel()
        {
            Console.WriteLine("Sony changechannel...");
        }

        public override void Off()
        {
            Console.WriteLine("Sony turn off...");
        }

        public override void On()
        {
            Console.WriteLine("Sony turn on...");
        }
    }
}

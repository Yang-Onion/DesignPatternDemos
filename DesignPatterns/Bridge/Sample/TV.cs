using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    /// <summary>
    /// Implementor
    /// </summary>
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void ChangeChannel();
    }
}

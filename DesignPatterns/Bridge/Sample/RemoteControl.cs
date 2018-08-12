using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    /// <summary>
    /// Abstract 
    /// </summary>
    public abstract class RemoteControl
    {
        public TV Implementor { get; set; }

        public virtual void On()
        {
            Implementor.On();
        }

        public virtual void Off()
        {
            Implementor.Off();
        }

        public virtual void ChangChanel()
        {
            Implementor.ChangeChannel();
        }
    }
}

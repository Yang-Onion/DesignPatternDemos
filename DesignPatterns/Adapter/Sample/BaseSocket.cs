using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample
{
    public abstract class BaseSocket
    {
        public virtual void GetElectric()
        {
            Console.WriteLine("Electric ....");
        }
    }
}

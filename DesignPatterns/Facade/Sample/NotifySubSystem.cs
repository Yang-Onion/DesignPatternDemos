using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Sample
{
    public class NotifySubSystem
    {
        public void Notify(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("success ...");
            }
            else
            {
                Console.WriteLine("failed...");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Samples
{
    public class BasicClass
    {
        public static BasicClass Instance
        {
            get { return new BasicClass(); }
        }
    }
}

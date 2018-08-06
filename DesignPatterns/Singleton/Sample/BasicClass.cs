using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Sample
{
    public class BasicClass
    {
        public static BasicClass Instance
        {
            get { return new BasicClass(); }
        }
    }
}

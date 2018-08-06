using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample
{
    public class FileLogFactory : LogFactory
    {
        public override Log CreateLog()
        {
            return new FileLog();
        }
    }
}

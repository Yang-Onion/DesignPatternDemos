using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Log
{
    public class FileLogFactory : LogFactory
    {
        public override Log CreateLog()
        {
            return new FileLog();
        }
    }
}

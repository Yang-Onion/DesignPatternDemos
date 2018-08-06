using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Log
{
    public class DatabaseLogFactory : LogFactory
    {
        public override Log CreateLog()
        {
            return new DatabaseLog();
        }
    }
}

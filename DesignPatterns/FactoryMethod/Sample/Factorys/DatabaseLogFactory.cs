using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample
{
    public class DatabaseLogFactory : LogFactory
    {
        public override Log CreateLog()
        {
            return new DatabaseLog();
        }
    }
}

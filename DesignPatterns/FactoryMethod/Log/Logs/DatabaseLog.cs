using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Log
{
    public class DatabaseLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("Database Loging....");
        }
    }
}

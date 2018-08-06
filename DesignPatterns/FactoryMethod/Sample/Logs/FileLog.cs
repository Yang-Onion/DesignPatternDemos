using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Sample
{
    public class FileLog : Log
    {
        public override void WriteLog()
        {
            Console.WriteLine("File Loging...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public class Context
    {
        public Context(string statement)
        {
            Statement = statement;
        }
        public string Statement { get; set; }
        public int Data { get; set; }
    }
}

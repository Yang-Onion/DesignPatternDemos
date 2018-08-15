using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public class HundredDigitExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override int Multipiler()
        {
            return 100;
        }
    }
}

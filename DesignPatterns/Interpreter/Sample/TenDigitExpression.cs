using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public class TenDigitExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override int Multipiler()
        {
            return 10;
        }
    }
}

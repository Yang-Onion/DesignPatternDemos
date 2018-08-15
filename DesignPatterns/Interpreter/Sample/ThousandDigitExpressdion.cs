using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public class ThousandDigitExpressdion : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override int Multipiler()
        {
            return 1000;
        }
    }
}

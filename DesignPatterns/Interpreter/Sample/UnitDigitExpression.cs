using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    /// <summary>
    /// 个位
    /// </summary>
    public class UnitDigitExpression : Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override int Multipiler()
        {
            return 1;
        }
        public override int GetLength()
        {
            return 1;
        }
    }
}

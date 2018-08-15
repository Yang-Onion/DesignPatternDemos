using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public class TenThousandDigitExpression : Expression
    {
        public override string GetPostFix()
        {
            return "万";
        }

        public override int Multipiler()
        {
            return 10000;
        }

        public override void Interpreter(Context context)
        {
            if (context.Statement.Length==0)
            {
                return;
            }
            List<Expression> expressList = new List<Expression>();
            expressList.Add(new UnitDigitExpression());
            expressList.Add(new TenDigitExpression());
            expressList.Add(new HundredDigitExpression());
            expressList.Add(new ThousandDigitExpressdion());
            expressList.Add(new TenThousandDigitExpression());

            foreach (var key in dictionary.Keys)
            {
                if (context.Statement.EndsWith(GetPostFix()))
                {
                    int temp = context.Data;
                    context.Data = 0;
                    context.Statement= context.Statement.Substring(0, context.Statement.Length - this.GetLength());

                    foreach (Expression exp in expressList)
                    {
                        exp.Interpreter(context);
                    }
                    context.Data = temp + context.Data + Multipiler();
                }

              
            }
        }
    }
}

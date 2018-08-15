using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Sample
{
    public abstract class Expression
    {
        protected Dictionary<string, int> dictionary = new Dictionary<string, int>();
        protected Expression()
        {
            dictionary.Add("一", 1);
            dictionary.Add("二", 2);
            dictionary.Add("三", 3);
            dictionary.Add("四", 4);
            dictionary.Add("五", 5);
            dictionary.Add("六", 6);
            dictionary.Add("七", 7);
            dictionary.Add("八", 8);
            dictionary.Add("九", 9);
        }

        public virtual void Interpreter(Context context)
        {
            if (context.Statement.Length==0)
            {
                return;
            }

            foreach (var key in dictionary.Keys)
            {
                if (context.Statement.EndsWith(key+ GetPostFix()))
                {
                    context.Data += dictionary[key] * Multipiler();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - GetLength());
                }
                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostFix();
        public abstract int Multipiler();
        public virtual int GetLength()
        {
            return GetPostFix().Length + 1;
        }
    }
}

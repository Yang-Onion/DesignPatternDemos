using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string chinaMoney = "五亿七千三百零二万六千四百五十二";

            Sample.Context context= new Sample.Context(chinaMoney);

            List<Sample.Expression> expressList = new List<Sample.Expression>();
            expressList.Add(new Sample.UnitDigitExpression());
            expressList.Add(new Sample.TenDigitExpression());
            expressList.Add(new Sample.HundredDigitExpression());
            expressList.Add(new Sample.ThousandDigitExpressdion());
            expressList.Add(new Sample.TenThousandDigitExpression());
            expressList.Add(new Sample.BillionDigitExpression());

            foreach (var item in expressList)
            {
                item.Interpreter(context);
            }

            Console.WriteLine($"{context.Data}");


            Console.Read();
        }
    }
}

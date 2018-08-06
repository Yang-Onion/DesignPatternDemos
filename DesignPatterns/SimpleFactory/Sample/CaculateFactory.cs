using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Sample
{
    public class CaculateFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;

            switch (operate)
            {
                case "+":
                    operation = new AddOperation();
                    break;
                case "-":
                    operation = new SubOperation();
                    break;
                case "*":
                    operation = new MultiOperation();
                    break;
                case "/":
                    operation = new DivOperation();
                    break;
                default:
                    break;
            }
            return operation;
        }
    }
}

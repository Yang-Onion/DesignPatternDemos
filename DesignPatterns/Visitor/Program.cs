using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            Sample.ObjectStructure structure = new Sample.ObjectStructure();

            var tv1 = new Sample.Television();
            tv1.Size = 100;
            tv1.State = 100;

            var tv2 = new Sample.Television();
            tv2.State = 200;
            tv2.Size = 200;


            structure.Add(tv1);
            structure.Add(tv2);


            var computer1 = new Sample.Computer();
            computer1.Size = 100;
            computer1.State = 100;

            var computer2 = new Sample.Computer();
            computer2.State = 90;
            computer2.Size = 101;

            structure.Add(computer1);
            structure.Add(computer2);

            Sample.SizeVisitor sizeVisitor = new Sample.SizeVisitor();
            Sample.StateVisitor stateVisitor = new Sample.StateVisitor();

            structure.Operate(stateVisitor);
            structure.Operate(sizeVisitor);

            Console.Read();

        }
    }
}

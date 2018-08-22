using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public class StateVisitor : Visitor
    {
        public override void PutComputer(Computer computer)
        {
            Console.WriteLine("按商品新旧值{0}排放", computer.State);
        }

        public override void PutTelevision(Television tv)
        {
            Console.WriteLine("按商品新旧值{0}排放", tv.State);
        }
    }
}

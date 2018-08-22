using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public class SizeVisitor : Visitor
    {
        public override void PutComputer(Computer computer)
        {
            Console.WriteLine("按商品大小{0}排放", computer.Size);
        }

        public override void PutTelevision(Television tv)
        {
            Console.WriteLine("按商品大小{0}排放", tv.Size);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Sample
{
    public class AfricaElephant : ElephantInFridge
    {
        public override void OpenFridge()
        {
            Console.WriteLine("打开西门子冰箱...");
        }

        public override void PutElephantIn(string elephantName)
        {
            Console.WriteLine($"将非洲象{elephantName}放进冰箱...");
        }
        public override void CloseFridge()
        {
            Console.WriteLine("关闭冰箱...");
        }
    }
}

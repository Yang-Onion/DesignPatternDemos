using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Sample
{
    public class AsiaElephant : ElephantInFridge
    {
        
        public override void OpenFridge()
        {
            Console.WriteLine("打开美的冰箱....");
        }

        public override void PutElephantIn(string elephantName)
        {
            Console.WriteLine($"将亚洲象{elephantName}放进冰箱....");
        }

        public override void CloseFridge()
        {
            Console.WriteLine("关闭冰箱....");
        }
    }
}

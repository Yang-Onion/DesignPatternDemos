using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Sample
{
    /// <summary>
    /// Abstract class 
    /// </summary>
    public abstract class ElephantInFridge
    {
        public string ElephantName { get; set; }

        /// <summary>
        /// Template Method 模板方法
        /// 将大象放到冰箱
        /// </summary>
        public void PutElephantInFridge()
        {
            
            OpenFridge();

            PutElephantIn(ElephantName);

            CloseFridge();

            Console.WriteLine("大象已经被放到冰箱里了");
        }

        public abstract void OpenFridge();
        public abstract void PutElephantIn(string elephantName);
        public abstract void CloseFridge();

    }
}

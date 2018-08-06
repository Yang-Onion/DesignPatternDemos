using System;
using System.Collections.Generic;

namespace Builder.Sample
{
    /// <summary>
    /// Product
    /// </summary>
    public class Computer
    {
        private List<string> _partList = new List<string>();
        
        /// <summary>
        /// 组装
        /// </summary>
        /// <param name="component">组件</param>
        public void Component(string component)
        {
            _partList.Add(component);
        }

        public void Processing()
        {
            Console.WriteLine("Begin Build...");
            foreach (var item in _partList)
            {
                Console.WriteLine($"正在组装{item}");
            }
            Console.WriteLine("End Build...");
        }
    }
}

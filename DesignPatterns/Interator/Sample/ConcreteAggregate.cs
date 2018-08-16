using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Sample
{
    public class ConcreteAggregate : Aggregate
    {
        private string[] collection;

        public ConcreteAggregate()
        {
            collection = new string[] { "许三多", "袁朗", "史今", "成材" };
        }
        public Interator GetInterator()
        {
            return new ConcreteInterator(this);
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public string GetElement(int index)
        {
            return collection[index];
        }

    }
}

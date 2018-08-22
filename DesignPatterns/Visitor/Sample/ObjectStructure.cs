using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Sample
{
    public class ObjectStructure
    {
        private List<Element> elementList = new List<Element>();
        
        public void Add(Element element)
        {
            if (!elementList.Contains(element))
            {
                elementList.Add(element);
            }
            
        }

        public void Detach(Element element)
        {
            if (elementList.Contains(element))
            {
                elementList.Remove(element);
            }
            
        }

        public void Operate(Visitor visitor)
        {
            elementList.ForEach(g =>
            {
                g.Operate(visitor);
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Sample
{
    public class ConcreteInterator : Interator
    {
        private readonly ConcreteAggregate _concreteAggregate;
        private  int _index;

        public ConcreteInterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
            _index = 0;
        }
        public object GetCurrent()
        {
            return _concreteAggregate.GetElement(_index);
        }

        public bool MoveNext()
        {
            if (_index<_concreteAggregate.Length)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if (_index < _concreteAggregate.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}

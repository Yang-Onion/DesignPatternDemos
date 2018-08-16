using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Sample
{
    public interface Interator
    {
        bool MoveNext();
        Object GetCurrent();

        void Next();

        void Reset();
    }
}

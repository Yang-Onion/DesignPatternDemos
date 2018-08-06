using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Sample
{
    public abstract class Builder
    {
        public abstract void CpuBuilder();
        public abstract void MainBoardBuilder();
        public abstract void KeyBoardBuilder();
        public abstract void MouseBuilder();

        public abstract Computer GetComputer();
    }
}

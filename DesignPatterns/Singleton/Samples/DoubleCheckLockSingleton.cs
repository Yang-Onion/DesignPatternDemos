using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Samples
{
    public sealed class DoubleCheckLockSingleton
    {
        static DoubleCheckLockSingleton instance = null;
        static readonly object obj = new object();

        DoubleCheckLockSingleton() { }

        public static DoubleCheckLockSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckLockSingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

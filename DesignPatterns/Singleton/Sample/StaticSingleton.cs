using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Sample
{
    public sealed class StaticSingleton
    {
        //_instance 是static readonly它只会在类加载的时间在静态ctor中初始化,只会初始化一次
        static readonly StaticSingleton _instance = new StaticSingleton();
        static StaticSingleton()
        {

        }
        StaticSingleton()
        {

        }

        public static StaticSingleton Instance
        {
            get { return _instance; }
        }
    }
}

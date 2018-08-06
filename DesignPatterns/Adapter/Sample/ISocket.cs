using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample
{
    /// <summary>
    /// 插座
    /// </summary>
    public interface ISocket
    {
        /// <summary>
        /// 获得电源
        /// </summary>
        void GetElectric();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample
{
    /// <summary>
    /// 插座转换器
    /// </summary>
    public class SocketAdapter : EuropeSocket, ISocket
    {
        public void GetElectric()
        {
            this.GetEuropStandardElectric();
        }
    }
}

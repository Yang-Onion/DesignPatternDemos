using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Sample
{
    public class ChinaSocketAdpter:BaseSocket
    {
        ChinaSocket chinaSocket = new ChinaSocket();

        public override void GetElectric()
        {
            chinaSocket.GetChinaStandardElectric();
        }
    }
}

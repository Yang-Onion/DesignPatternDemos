using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Sample
{
    /// <summary>
    /// 也可以是抽象类
    /// </summary>
    public interface IMediator
    {
        void Command(Employee employee);
    }
}

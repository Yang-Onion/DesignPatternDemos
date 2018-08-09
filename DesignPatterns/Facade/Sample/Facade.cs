using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Sample
{
    public class Facade
    {
        private RegistSubSystem registSubSystem;
        private NotifySubSystem notifySubSystem;

        public Facade()
        {
            registSubSystem = new RegistSubSystem();
            notifySubSystem = new NotifySubSystem();
        }

        public void SelectCourse()
        {
            if (registSubSystem.Regist())
            {
                notifySubSystem.Notify(true);
            }
            else
            {
                notifySubSystem.Notify(false);
            }

        }
    }
}

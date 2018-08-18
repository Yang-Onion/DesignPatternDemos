using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sample
{
    public class Memento
    {
        public List<ContactPhone> ContactPhoneBackUp { get; set; }

        public Memento(List<ContactPhone> contactPhoneList)
        {
            ContactPhoneBackUp = contactPhoneList;
        }
    }
}

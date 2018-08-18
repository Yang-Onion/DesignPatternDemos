using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sample
{
    public class Originator
    {

        public List<ContactPhone> ContactPhoneList { get; set; }

        public Originator(List<ContactPhone> contactPhoneList)
        {
            ContactPhoneList = contactPhoneList ?? throw new ArgumentNullException();
        }

        public Memento CreateMemento()
        {
            //这里不能直接传ContactList给备忘录,这样是传递引用,
            //当删除某个联系人的时候，这个引用中的联系人也会被删除。 
            //return new Memento(ContactPhoneList);

            return new Memento(new List<ContactPhone>(ContactPhoneList));
        }

        public void ReBackMemento(Memento memento)
        {
            ContactPhoneList = memento.ContactPhoneBackUp;
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中共有{0}个人，他们是:", ContactPhoneList.Count);
            foreach (var item in ContactPhoneList)
            {
                Console.WriteLine($"{item.PhoneMaster}:{item.PhoneNum}");
            }
        }

    }
}

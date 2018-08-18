using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactPhoneList = new List<Sample.ContactPhone>()
            {
                new Sample.ContactPhone(){ PhoneMaster="Yang-Onion",PhoneNum="13900000000"},
                new Sample.ContactPhone(){ PhoneMaster="张三",PhoneNum="13666666666"},
                new Sample.ContactPhone(){ PhoneMaster="李四",PhoneNum="18888888888"}
            };

            Sample.Originator originator = new Sample.Originator(contactPhoneList);
            originator.Show();

            Sample.Caretaker caretaker = new Sample.Caretaker();
            caretaker.Memento = originator.CreateMemento();

            Console.WriteLine("移除最后一个联系人");
            originator.ContactPhoneList.RemoveAt(contactPhoneList.Count() - 1);
            originator.Show();

            Console.WriteLine("恢复联系人");
            originator.ReBackMemento(caretaker.Memento);
            originator.Show();


            Console.Read();
        }
    }
}

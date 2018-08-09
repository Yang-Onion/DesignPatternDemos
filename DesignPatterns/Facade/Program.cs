using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.Facade facade = new Sample.Facade();
            facade.SelectCourse();

            Console.Read();
        }
    }
}

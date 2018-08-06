using Singleton.Sample;
using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                () => Console.WriteLine($"hashcode:{StaticSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{StaticSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{StaticSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{StaticSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{StaticSingleton.Instance.GetHashCode()}")
                );

            Parallel.Invoke(
                () => Console.WriteLine($"hashcode:{DoubleCheckLockSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{DoubleCheckLockSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{DoubleCheckLockSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{DoubleCheckLockSingleton.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{DoubleCheckLockSingleton.Instance.GetHashCode()}")
                );

            Parallel.Invoke(
                () => Console.WriteLine($"hashcode:{BasicClass.Instance.GetHashCode()}"),
                () => Console.WriteLine($"hashcode:{BasicClass.Instance.GetHashCode()}")
                );
            Console.Read();
        }
    }
}

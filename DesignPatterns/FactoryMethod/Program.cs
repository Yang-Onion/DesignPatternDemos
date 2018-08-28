using FactoryMethod.Sample;
using System;
using System.Reflection;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LogFactory factory = new DatabaseLogFactory();
            FactoryMethod.Sample.Log log = factory.CreateLog();
            log.WriteLog();

            //从配置文件读取
            //var factoryName = "FileLog";
            //LogFactory factory;
            //factory = (LogFactory)Assembly.Load("FactoryMethod").CreateInstance("FactoryMethod.Sample." + factoryName);
            //Log log = factory.CreateLog();
            //log.WriteLog();

            Console.Read();
        }
    }
}

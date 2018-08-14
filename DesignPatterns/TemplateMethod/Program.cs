using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.ElephantInFridge putAisaElephantInFridge = new Sample.AsiaElephant();
            putAisaElephantInFridge.ElephantName = "泰山";
            putAisaElephantInFridge.PutElephantInFridge();

            Sample.ElephantInFridge putAfricaElephantInFridge = new Sample.AfricaElephant();
            putAfricaElephantInFridge.ElephantName = "马扎罗";
            putAfricaElephantInFridge.PutElephantInFridge();


            Console.Read();

        }
    }
}

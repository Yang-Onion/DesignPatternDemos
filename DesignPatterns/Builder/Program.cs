using Builder.Sample;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {


            Sample.Builder notebookBuilder = new NoteBookBuilder();
            Sample.Builder gameComputerBuilder = new GameComputerBuilder();

            Director director = new Director();

            director.Construct(notebookBuilder);
            Computer notebook = notebookBuilder.GetComputer();
            notebook.Processing();

            Console.WriteLine("-------------");

            director.Construct(gameComputerBuilder);
            Computer gameComputer = gameComputerBuilder.GetComputer();
            gameComputer.Processing();

            Console.Read();
        }
    }
}

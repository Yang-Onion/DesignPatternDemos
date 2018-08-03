using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public class NoteBookBuilder : Builder
    {
        Computer computer = new Computer();
        public override void CpuBuilder()
        {
            computer.Component("Cpu:Intel Core i7");
        }

        public override void KeyBoardBuilder()
        {
            //computer.Component("KeyBoard:build in keyboard");
        }

        public override void MainBoardBuilder()
        {
            computer.Component("MainBoard:Asus");
        }

        public override void MouseBuilder()
        {
            computer.Component("Mouse:Rapoo wireless");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderPattern
{
    class RemoteInvoker
    {
        Stack<ICommander> stack = new Stack<ICommander>();
        ICommander commander;
        public RemoteInvoker()
        {
            
        }
        public void SetCommand(ICommander commander)
        {
            this.commander = commander;
        }
        public void PressButton()
        {
            stack.Push(commander);
            commander.Execute();
        }
        public void Undo()
        {
            if(stack.Count()!=0)
            {
               ICommander commander2= stack.Pop();
                commander2.Undo();
            }
        }

    }
}

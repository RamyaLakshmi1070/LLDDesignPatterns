using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderPattern
{
    class TurnOnAcCommander : ICommander
    {
        bool IsOn = false;
        public void Execute()
        {
            IsOn = true;
            Console.WriteLine("Ac Turned on Successfully");
        }
        public void Undo()
        {
            Console.WriteLine("Reverted");
            IsOn = false;
        }
    }
}

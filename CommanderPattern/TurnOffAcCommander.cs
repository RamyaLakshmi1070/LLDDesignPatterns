using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderPattern
{
    class TurnOffAcCommander : ICommander
    {
        bool IsOn = true;
        public void Execute()
        {
            IsOn = false;
            Console.WriteLine("AC turned Off Successfully");
        }
        public void Undo()
        {
            Console.WriteLine("Reverted");
            IsOn = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    class DebugHandler : LogHandler
    {
        public DebugHandler(LogHandler logHandler) : base(logHandler)
        {
        }
        public override void Log(int logLevel,String message)
        {
            if (logLevel == Debug)
                Console.WriteLine("Debug Log {0}", message);
            else
                base.Log(logLevel, message);
        }
    }
}

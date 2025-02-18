using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    class ErrorLogHandler : LogHandler
    {
        public ErrorLogHandler(LogHandler logHandler) : base(logHandler)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if(logLevel==Error)
                Console.WriteLine("Error Log {0}",message);
            else
                base.Log(logLevel, message);
        }
    }
}

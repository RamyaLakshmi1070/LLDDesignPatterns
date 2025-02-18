using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    class InfoLogHandler : LogHandler
    {
        public InfoLogHandler(LogHandler logHandler) :base(logHandler)
        {

        }
        public override void Log(int logLevel, String message)
        {
            if (logLevel == Info)
            {
                Console.WriteLine("Log :{0}", message);
            }
            else
            {
                base.Log(logLevel, message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    abstract class LogHandler
    {
        LogHandler nextLogHandler;
        public static int Info = 1;
        public static int Debug = 2;
        public static int Error = 3;

        protected LogHandler(LogHandler logHandler)
        {
            nextLogHandler = logHandler;
        }

        public virtual void Log(int logLevel,String message)
        {
            if (nextLogHandler != null)
                nextLogHandler.Log(logLevel, message);
        }

    }
}

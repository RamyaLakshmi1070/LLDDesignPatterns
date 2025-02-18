namespace ChainOfResponsibiltyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogHandler logHandler = new InfoLogHandler(new DebugHandler(new ErrorLogHandler(null)));

            logHandler.Log(LogHandler.Error, "Exception thrown");
            logHandler.Log(LogHandler.Debug, "Debug ");
            logHandler.Log(LogHandler.Info, "Info  Log");
        }
    }
}

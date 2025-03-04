namespace CommanderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteInvoker remoteInvoker = new RemoteInvoker();
            remoteInvoker.SetCommand(new TurnOnAcCommander());
            remoteInvoker.PressButton();
        }
    }
}

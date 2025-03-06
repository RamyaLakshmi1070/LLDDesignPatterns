namespace MementoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConfigurationOriginator configurationOriginator = new ConfigurationOriginator(100,200);
            ConfigurationCareTaker configurationCareTaker = new ConfigurationCareTaker();
            var configurationMemto = configurationOriginator.CreateMemento();
            configurationCareTaker.AddMemento(configurationMemto);

            configurationOriginator.SetWeight(300);
            configurationOriginator.SetHeight(400);
            ConfigurationMemto configurationMemto1=configurationOriginator.CreateMemento();

            configurationCareTaker.AddMemento(configurationMemto1);

            configurationOriginator.SetWeight(300);
            configurationOriginator.SetHeight(400);
            ConfigurationMemto configurationMemt2 = configurationOriginator.CreateMemento();

            configurationCareTaker.AddMemento(configurationMemt2);

           ConfigurationMemto configurationMemto2= configurationCareTaker.Undo();
            configurationOriginator.RestoreMemento(configurationMemto2);

            Console.WriteLine(configurationOriginator.h);
            Console.WriteLine(configurationOriginator.w);


        }
    }
}

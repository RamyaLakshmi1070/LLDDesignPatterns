namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRoomElement roomElement = new SingleRoom();
            roomElement.accept(new RoomPricing());
            roomElement.accept(new RoomMaintenance());
        }
    }
}

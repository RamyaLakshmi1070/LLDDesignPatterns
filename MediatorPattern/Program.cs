namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new AuctionMediator();
            IColleague colleague = new Bidder("Sheela", mediator);
            colleague.PlaceBid(1000);
            IColleague colleague1 = new Bidder("Ramya", mediator);
            colleague1.PlaceBid(3999);
            colleague.PlaceBid(4000);
        }
    }
}

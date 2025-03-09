namespace ElevatorSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElevatorCart elevator = new ElevatorCart();
            ElevatorController controller = new ElevatorController(elevator);
            ExternalButton externalDispatcher = new ExternalButton();
            InternalButton internalButton = new InternalButton();

            // Simulate external requests
            new ExternalButton().PressButton(controller, Direction.UP,1);
            new ExternalButton().PressButton(controller, Direction.UP,2);
            new ExternalButton().PressButton(controller, Direction.DOWN,3);

            // Simulate internal requests
            internalButton.PressButton(controller,2);
            internalButton.PressButton(controller,4);
        }
    }  
}

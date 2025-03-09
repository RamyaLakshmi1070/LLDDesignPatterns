
namespace ElevatorSystem
{
    internal class ExternalDispatcher
    {
        internal void SubmitExternalRequest(ElevatorController controller, Direction direction, int floor)
        {
            controller.SubmitExternalRequest(floor,direction);
        }
    }
}
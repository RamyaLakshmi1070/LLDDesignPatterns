
namespace ElevatorSystem
{
    internal class ElevatorCreator
    {
        internal static List<ElevatorController> ElevatorList()
        {
            List<ElevatorController> elevatorControllerList = new List<ElevatorController>();
            ElevatorCart  elevatorCar1 = new ElevatorCart();
            elevatorCar1.id = 1;
            ElevatorController controller1 = new ElevatorController(elevatorCar1);

            ElevatorCart elevatorCar2 = new ElevatorCart();
            elevatorCar1.id = 2;
            ElevatorController controller2 = new ElevatorController(elevatorCar2);

            elevatorControllerList.Add(controller1);
            elevatorControllerList.Add(controller1);
            return elevatorControllerList;
        }
    }
}
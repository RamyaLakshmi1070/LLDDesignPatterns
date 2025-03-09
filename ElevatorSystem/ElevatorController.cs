
namespace ElevatorSystem
{
    public class ElevatorController
    {
        private PriorityQueue<int, int> upMinPQ;
        private PriorityQueue<int, int> downMaxPQ;
        public  ElevatorCart elevatorCar;

        public ElevatorController(ElevatorCart elevatorCar)
        {
            this.elevatorCar = elevatorCar;
            upMinPQ = new PriorityQueue<int, int>();
            downMaxPQ = new PriorityQueue<int, int>();
        }

        public void SubmitExternalRequest(int floor, Direction direction)
        {
            if (direction == Direction.DOWN)
            {
                downMaxPQ.Enqueue(floor, -floor);
            }
            else
            {
                upMinPQ.Enqueue(floor, floor);
            }
            ControlElevator();
        }

        public void SubmitInternalRequest(int floor)
        {
            if (floor > elevatorCar.GetCurrentFloor())
            {
                upMinPQ.Enqueue(floor, floor);
            }
            else
            {
                downMaxPQ.Enqueue(floor, -floor);
            }
            ControlElevator();
        }

        private void ControlElevator()
        {
            while (upMinPQ.Count > 0 || downMaxPQ.Count > 0)
            {
                while (upMinPQ.Count > 0)
                {
                    elevatorCar.Move(upMinPQ.Dequeue());
                }
                while (downMaxPQ.Count > 0)
                {
                    elevatorCar.Move(downMaxPQ.Dequeue());
                }
            }
        }
    }
}
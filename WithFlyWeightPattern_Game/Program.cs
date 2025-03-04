namespace WithFlyWeightPattern_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotFactory robotFactory = new RobotFactory();
            IRobot robot = robotFactory.CreateRobot("Humanoid");
            robot.Display(10, 11);

            
            IRobot robot1 = robotFactory.CreateRobot("Humanoid");
            robot1.Display(11, 11);

            IRobot robot2 = robotFactory.CreateRobot("DogRobot");
            robot2.Display(12, 11);

            IRobot robot3 = robotFactory.CreateRobot("DogRobot");
            robot3.Display(12, 11);
        }
    }
}

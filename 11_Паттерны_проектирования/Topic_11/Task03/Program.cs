namespace Task03
{
    class Program
    {
        public static void Main(string[] args)
        {
            RobotVacuum robot = new RobotVacuum();

            ICommand start = new StartCleaningCommand(robot);
            ICommand stop = new StopCleaningCommand(robot); 
            ICommand returnToBase = new ReturnToBaseCommand(robot);

            RobotController controller = new RobotController();
            controller.SetCommand(start);
            controller.PressButton();

            controller.SetCommand(stop);
            controller.PressButton();

            controller.SetCommand(returnToBase);
            controller.PressButton();
        }
    }
}
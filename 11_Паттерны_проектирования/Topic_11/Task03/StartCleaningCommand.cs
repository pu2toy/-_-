using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class StartCleaningCommand : ICommand
    {
        private RobotVacuum _robot;

        public StartCleaningCommand(RobotVacuum robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StartCleaning();
        }
    }
}

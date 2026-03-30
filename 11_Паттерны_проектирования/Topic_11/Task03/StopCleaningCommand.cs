using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class StopCleaningCommand : ICommand
    {
        private RobotVacuum _robot;
        public StopCleaningCommand(RobotVacuum robot) {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StopCleaning();
        }
    }
}
